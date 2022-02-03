namespace eKuharica.WinUI.Recipes
{
    partial class frmShowRecipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowRecipes));
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gbCover = new System.Windows.Forms.GroupBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLikesDisplay = new System.Windows.Forms.Label();
            this.rtbIntroduction = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.btnMethodMore = new System.Windows.Forms.Button();
            this.lblMethod = new System.Windows.Forms.Label();
            this.rtbMethod = new System.Windows.Forms.RichTextBox();
            this.gbAdvice = new System.Windows.Forms.GroupBox();
            this.btnAdviceMore = new System.Windows.Forms.Button();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.rtbAdvice = new System.Windows.Forms.RichTextBox();
            this.gbServing = new System.Windows.Forms.GroupBox();
            this.btnServingMore = new System.Windows.Forms.Button();
            this.lblServing = new System.Windows.Forms.Label();
            this.rtbServing = new System.Windows.Forms.RichTextBox();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblWeightOfPrep = new System.Windows.Forms.Label();
            this.gbLike = new System.Windows.Forms.GroupBox();
            this.lblNumberOfLikes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbCover.SuspendLayout();
            this.gbIngredients.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.gbAdvice.SuspendLayout();
            this.gbServing.SuspendLayout();
            this.gbLike.SuspendLayout();
            this.gbComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            resources.ApplyResources(this.pbPicture, "pbPicture");
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.TabStop = false;
            // 
            // gbCover
            // 
            resources.ApplyResources(this.gbCover, "gbCover");
            this.gbCover.Controls.Add(this.btnLike);
            this.gbCover.Controls.Add(this.lblTitle);
            this.gbCover.Controls.Add(this.lblAuthor);
            this.gbCover.Controls.Add(this.pbPicture);
            this.gbCover.Name = "gbCover";
            this.gbCover.TabStop = false;
            // 
            // btnLike
            // 
            resources.ApplyResources(this.btnLike, "btnLike");
            this.btnLike.Name = "btnLike";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.Name = "lblAuthor";
            // 
            // lblLikesDisplay
            // 
            resources.ApplyResources(this.lblLikesDisplay, "lblLikesDisplay");
            this.lblLikesDisplay.Name = "lblLikesDisplay";
            // 
            // rtbIntroduction
            // 
            resources.ApplyResources(this.rtbIntroduction, "rtbIntroduction");
            this.rtbIntroduction.Name = "rtbIntroduction";
            this.rtbIntroduction.ReadOnly = true;
            // 
            // lblIngredients
            // 
            resources.ApplyResources(this.lblIngredients, "lblIngredients");
            this.lblIngredients.Name = "lblIngredients";
            // 
            // gbIngredients
            // 
            this.gbIngredients.Controls.Add(this.rtbIngredients);
            this.gbIngredients.Controls.Add(this.lblIngredients);
            resources.ApplyResources(this.gbIngredients, "gbIngredients");
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.TabStop = false;
            // 
            // rtbIngredients
            // 
            resources.ApplyResources(this.rtbIngredients, "rtbIngredients");
            this.rtbIngredients.Name = "rtbIngredients";
            // 
            // gbMethod
            // 
            resources.ApplyResources(this.gbMethod, "gbMethod");
            this.gbMethod.Controls.Add(this.btnMethodMore);
            this.gbMethod.Controls.Add(this.lblMethod);
            this.gbMethod.Controls.Add(this.rtbMethod);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.TabStop = false;
            // 
            // btnMethodMore
            // 
            resources.ApplyResources(this.btnMethodMore, "btnMethodMore");
            this.btnMethodMore.Name = "btnMethodMore";
            this.btnMethodMore.UseVisualStyleBackColor = true;
            this.btnMethodMore.Click += new System.EventHandler(this.btnMethodMore_Click);
            // 
            // lblMethod
            // 
            resources.ApplyResources(this.lblMethod, "lblMethod");
            this.lblMethod.Name = "lblMethod";
            // 
            // rtbMethod
            // 
            resources.ApplyResources(this.rtbMethod, "rtbMethod");
            this.rtbMethod.Name = "rtbMethod";
            // 
            // gbAdvice
            // 
            resources.ApplyResources(this.gbAdvice, "gbAdvice");
            this.gbAdvice.Controls.Add(this.btnAdviceMore);
            this.gbAdvice.Controls.Add(this.lblAdvice);
            this.gbAdvice.Controls.Add(this.rtbAdvice);
            this.gbAdvice.Name = "gbAdvice";
            this.gbAdvice.TabStop = false;
            // 
            // btnAdviceMore
            // 
            resources.ApplyResources(this.btnAdviceMore, "btnAdviceMore");
            this.btnAdviceMore.Name = "btnAdviceMore";
            this.btnAdviceMore.UseVisualStyleBackColor = true;
            this.btnAdviceMore.Click += new System.EventHandler(this.btnAdviceMore_Click);
            // 
            // lblAdvice
            // 
            resources.ApplyResources(this.lblAdvice, "lblAdvice");
            this.lblAdvice.Name = "lblAdvice";
            // 
            // rtbAdvice
            // 
            resources.ApplyResources(this.rtbAdvice, "rtbAdvice");
            this.rtbAdvice.Name = "rtbAdvice";
            // 
            // gbServing
            // 
            resources.ApplyResources(this.gbServing, "gbServing");
            this.gbServing.Controls.Add(this.btnServingMore);
            this.gbServing.Controls.Add(this.lblServing);
            this.gbServing.Controls.Add(this.rtbServing);
            this.gbServing.Name = "gbServing";
            this.gbServing.TabStop = false;
            // 
            // btnServingMore
            // 
            resources.ApplyResources(this.btnServingMore, "btnServingMore");
            this.btnServingMore.Name = "btnServingMore";
            this.btnServingMore.UseVisualStyleBackColor = true;
            this.btnServingMore.Click += new System.EventHandler(this.btnServingMore_Click);
            // 
            // lblServing
            // 
            resources.ApplyResources(this.lblServing, "lblServing");
            this.lblServing.Name = "lblServing";
            // 
            // rtbServing
            // 
            resources.ApplyResources(this.rtbServing, "rtbServing");
            this.rtbServing.Name = "rtbServing";
            // 
            // lblPrepTime
            // 
            resources.ApplyResources(this.lblPrepTime, "lblPrepTime");
            this.lblPrepTime.Name = "lblPrepTime";
            // 
            // lblMealType
            // 
            resources.ApplyResources(this.lblMealType, "lblMealType");
            this.lblMealType.Name = "lblMealType";
            // 
            // lblWeightOfPrep
            // 
            resources.ApplyResources(this.lblWeightOfPrep, "lblWeightOfPrep");
            this.lblWeightOfPrep.Name = "lblWeightOfPrep";
            // 
            // gbLike
            // 
            this.gbLike.Controls.Add(this.lblNumberOfLikes);
            this.gbLike.Controls.Add(this.lblLikesDisplay);
            resources.ApplyResources(this.gbLike, "gbLike");
            this.gbLike.Name = "gbLike";
            this.gbLike.TabStop = false;
            // 
            // lblNumberOfLikes
            // 
            resources.ApplyResources(this.lblNumberOfLikes, "lblNumberOfLikes");
            this.lblNumberOfLikes.Name = "lblNumberOfLikes";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbComments
            // 
            resources.ApplyResources(this.gbComments, "gbComments");
            this.gbComments.Controls.Add(this.txtComment);
            this.gbComments.Controls.Add(this.btnAddComment);
            this.gbComments.Controls.Add(this.rtbComments);
            this.gbComments.Name = "gbComments";
            this.gbComments.TabStop = false;
            // 
            // txtComment
            // 
            resources.ApplyResources(this.txtComment, "txtComment");
            this.txtComment.Name = "txtComment";
            // 
            // btnAddComment
            // 
            resources.ApplyResources(this.btnAddComment, "btnAddComment");
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // rtbComments
            // 
            resources.ApplyResources(this.rtbComments, "rtbComments");
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ReadOnly = true;
            // 
            // cmbRating
            // 
            resources.ApplyResources(this.cmbRating, "cmbRating");
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.SelectionChangeCommitted += new System.EventHandler(this.cmbRating_SelectionChangeCommitted);
            // 
            // frmShowRecipes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.gbServing);
            this.Controls.Add(this.gbLike);
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.gbAdvice);
            this.Controls.Add(this.lblWeightOfPrep);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.rtbIntroduction);
            this.Controls.Add(this.gbCover);
            this.Name = "frmShowRecipes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmShowRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbCover.ResumeLayout(false);
            this.gbCover.PerformLayout();
            this.gbIngredients.ResumeLayout(false);
            this.gbIngredients.PerformLayout();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbAdvice.ResumeLayout(false);
            this.gbAdvice.PerformLayout();
            this.gbServing.ResumeLayout(false);
            this.gbServing.PerformLayout();
            this.gbLike.ResumeLayout(false);
            this.gbLike.PerformLayout();
            this.gbComments.ResumeLayout(false);
            this.gbComments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox gbCover;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLikesDisplay;
        private System.Windows.Forms.RichTextBox rtbIntroduction;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.GroupBox gbAdvice;
        private System.Windows.Forms.GroupBox gbServing;
        private System.Windows.Forms.RichTextBox rtbMethod;
        private System.Windows.Forms.RichTextBox rtbAdvice;
        private System.Windows.Forms.RichTextBox rtbServing;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Label lblWeightOfPrep;
        private System.Windows.Forms.GroupBox gbLike;
        private System.Windows.Forms.Button btnMethodMore;
        private System.Windows.Forms.Button btnAdviceMore;
        private System.Windows.Forms.Button btnServingMore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblNumberOfLikes;
    }
}