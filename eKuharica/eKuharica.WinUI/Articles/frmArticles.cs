﻿using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.WinUI.Recipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Articles
{
    public partial class frmArticles : Form
    {
        APIService _articleService = new APIService("Article");
        APIService _articleTranslationService = new APIService("ArticleTranslation");
        APIService _userService = new APIService("User");
        public frmArticles()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Helpers.Helper.CurrentLanguage);

            InitializeComponent();
            sdgvArticles.AutoGenerateColumns = false;
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            frmAddArticles frmAddArticles = new frmAddArticles();
            frmAddArticles.MdiParent = MdiParent;
            frmAddArticles.WindowState = FormWindowState.Maximized;
            frmAddArticles.Show();
            Hide();
        }

        private async void frmArticles_Load(object sender, EventArgs e)
        {
            var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            var data = await _articleService.Get<List<ArticleDto>>(new ArticleSearchRequest() { 
                LoggedUserId = user.Id, 
                LoggedUserHasPermissions = Helpers.Helper.IsAdminOrEmployee(user) 
            });

            LoadData(data);
        }

        private void LoadData(List<ArticleDto> data)
        {
            if (!data.Any())
                sdgvArticles.DataSource = null;
            else
            {
                sdgvArticles.DataSource = data;
                Helpers.Helper.TranslationForDgvButtons(this, sdgvArticles);

                sdgvArticles.PageSize = 10;
                DataTable dt = Helpers.Helper.ToDataTable(data);
                sdgvArticles.SetPagedDataSource(dt, bindingNavigator1);
            }
        }

        private async void sdgvArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var currentRow = bindingNavigator1.BindingSource.Current as DataTable;
                //TODO:mozda ce trebati dodati 1 na index
                var elementIndex = (currentRow.Rows.Count / 10) <= 1 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
                var selectedRow = Helpers.Helper.CreateItemFromRow<ArticleDto>(currentRow.Rows[elementIndex]);

                var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

                if (!Helpers.Helper.IsAdministrator(user) && !selectedRow.IsCreatedByLoggedUser &&
                    (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5))
                {
                    MessageBox.Show("Nemate permisije");
                    return;
                }

                var searchR = new ArticleTranslationDto() { ArticleId = selectedRow.Id };
                var articleTranslation = await _articleTranslationService.Get<List<ArticleTranslationDto>>(searchR);
                var _articleTranslation = articleTranslation.Any() ? articleTranslation.First() : null;

                if (e.ColumnIndex == 2)//prevod
                {
                    frmAddArticles frmEditArticleTranslation = new frmAddArticles(selectedRow, _articleTranslation, true);
                    frmEditArticleTranslation.MdiParent = MdiParent;
                    frmEditArticleTranslation.WindowState = FormWindowState.Maximized;
                    frmEditArticleTranslation.Show();
                    Hide();
                }
                if (e.ColumnIndex == 3)//prikazi
                {
                    frmShowArticles frmShowArticle = new frmShowArticles(selectedRow);
                    frmShowArticle.MdiParent = MdiParent;
                    frmShowArticle.WindowState = FormWindowState.Maximized;
                    frmShowArticle.Show();
                    Hide();
                }
                if (e.ColumnIndex == 4)//edit
                {
                    frmAddArticles frmEditArticle = new frmAddArticles(selectedRow, _articleTranslation);
                    frmEditArticle.MdiParent = MdiParent;
                    frmEditArticle.WindowState = FormWindowState.Maximized;
                    frmEditArticle.Show();
                    Hide();
                }
                if (e.ColumnIndex == 5)//brisanje
                {
                    if (await _articleService.Delete<ArticleDto>(selectedRow.Id))
                        txtSearchArticle_TextChanged(sender, e);
                }
            }
        }

        private async void txtSearchArticle_TextChanged(object sender, EventArgs e)
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            ArticleSearchRequest request = new ArticleSearchRequest()
            {
                Title = txtSearchArticle.Text,
                LoggedUserId = loggedUser.Id,
                LoggedUserHasPermissions = Helpers.Helper.IsAdminOrEmployee(loggedUser)
            };

            var data = await _articleService.Get<List<ArticleDto>>(request);
            LoadData(data);
        }
    }
}
