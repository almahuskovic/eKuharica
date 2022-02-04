using eKuharica.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica
{
    public class SetupService
    {
        public void Init(Context context)
        {
            context.Database.Migrate();
            
            #region ROLE

            if (!context.Role.Any(x => x.Name == "Administrator"))
            {
                context.Role.Add(new Role { Name = "Administrator" });
            }
            if (!context.Role.Any(x => x.Name == "Zaposlenik"))
            {
                context.Role.Add(new Role { Name = "Zaposlenik" });
            }
            if (!context.Role.Any(x => x.Name == "Korisnik"))
            {
                context.Role.Add(new Role { Name = "Korisnik" });
            }
            context.SaveChanges();

            #endregion ROLES

            #region USERS

            var adminUlogaId = context.Role.First(x => x.Name == "Administrator").Id;
            var zaposlenikUlogaId = context.Role.First(x => x.Name == "Zaposlenik").Id;
            var korisnikUlogaId = context.Role.First(x => x.Name == "Korisnik").Id;

            if (!context.User.Any(x => x.Username == "Administrator"))
            {
                context.User.Add(new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "060-000-000",
                    Username = "admin",
                    PasswordHash = "RChwqvrLWl6TKV9w/xHxQEoCMD0=",
                    PasswordSalt = "BhgJV01VzZl89bY5MNRGAg=="
                });
            }
            if (!context.User.Any(x => x.Username == "Zaposlenik"))
            {
                context.User.Add(new User
                {
                    FirstName = "Zaposlenik",
                    LastName = "Zaposlenik",
                    Email = "zaposlenik@gmail.com",
                    PhoneNumber = "060-000-000",
                    Username = "zaposlenik",
                    PasswordHash = "kzPMtkurthKr25PVJRgwebdbo2E=",
                    PasswordSalt = "4bgl7Tmio32Xo8EWI5V9rg=="
                });
            }
            if (!context.User.Any(x => x.Username == "Korisnik"))
            {
                context.User.Add(new User
                {
                    FirstName = "Korisnik",
                    LastName = "Korisnik",
                    Email = "korisnik@gmail.com",
                    PhoneNumber = "060-000-000",
                    Username = "korisnik",
                    PasswordHash = "dVCxsxiICaay1QUTOLv0eds4dH4=",
                    PasswordSalt = "4GUgnJtIdixLA35nRIuajQ=="
                });
            }
            if (!context.User.Any(x => x.Username == "KorisnikTest"))
            {
                context.User.Add(new User
                {
                    FirstName = "KorisnikTest",
                    LastName = "KorisnikTest",
                    Email = "korisnikTest@gmail.com",
                    PhoneNumber = "060-000-000",
                    Username = "klijenttest",
                    PasswordHash = "B12FHS/6dFsyUYamekEanf5aUMQ=",
                    PasswordSalt = "FLwIerOCNwMX/P0GuTKhWA=="
                });
            }
            context.SaveChanges();

            #endregion USERS

            #region USERROLES

            var adminId = context.User.First(x => x.Username == "Administrator").Id;
            var zaposlenikId = context.User.First(x => x.Username == "Zaposlenik").Id;
            var korisnikId = context.User.First(x => x.Username == "Korisnik").Id;
            var korisnikTestId = context.User.First(x => x.Username == "KorisnikTest").Id;

            if (!context.UserRole.Any(x => x.UserId == adminId && x.RoleId == adminUlogaId))
            {
                context.UserRole.Add(new UserRole
                {
                    RoleId = adminUlogaId,
                    UserId = adminId
                });
            }
            if (!context.UserRole.Any(x => x.UserId == zaposlenikId && x.RoleId == zaposlenikUlogaId))
            {
                context.UserRole.Add(new UserRole
                {
                    RoleId = zaposlenikUlogaId,
                    UserId = zaposlenikId
                });
            }
            if (!context.UserRole.Any(x => x.UserId == korisnikId && x.RoleId == korisnikUlogaId))
            {
                context.UserRole.Add(new UserRole
                {
                    RoleId = korisnikUlogaId,
                    UserId = korisnikId
                });
            }
            if (!context.UserRole.Any(x => x.UserId == korisnikId && x.RoleId == korisnikTestId))
            {
                context.UserRole.Add(new UserRole
                {
                    RoleId = korisnikUlogaId,
                    UserId = korisnikTestId
                });
            }
            context.SaveChanges();

            #endregion

            #region ARTICLE

            if (!context.Article.Any(x => x.Title == "Danas imamo sladoled za doručak!"))
            {
                context.Article.Add(new Article
                {
                    Title = "Danas imamo sladoled za doručak!",
                    Content = "Šezdesetih godina, u snijegom pokrivenom Rochesteru, na sjeveru države New York, majka šestero djece mislila je da će poludjeti pa je izmislila «sladoled za doručak».\nFlorence je bila očajna. Vani je padao gusti snijeg koji je zameo cijeli Rochester, u državi New York, temperatura je bila polarna, a njezino šestero djece nije htjelo čuti da se bavi mirnim aktivnostima poput crtanja, šaha, čitanja, igranja karata. Bili su puni one neobuzdane, dječje mašte i energije koja podrazumijeva fizički umor kako bi se smirila. Ponedjeljak, i odlazak u školu, činio se nedostižnom iluzijom. Trebala je pod hitno nešto smisliti.\n«Danas imamo sladoled za doručak!», bile su čarobne riječi dovoljne da nastane muk.",
                    IsTranslated = true,
                    KeyWords = "sladoled",
                    //Picture="",
                    CreateUserId = adminId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }
            if (!context.Article.Any(x => x.Title == "Kuhati u velikim loncima"))
            {
                context.Article.Add(new Article
                {
                    Title = "Kuhati u velikim loncima",
                    Content = "Veličina lonaca određuje što ćemo kuhati. U velikim loncima najbolje od sebe daju variva i guste juhe od mahunarki, žitarica i korjenastog povrća.\nVeličina lonca i tava koje namjeravamo upotrijebiti, određuje što ćemo i kako kuhati. Ne mislim tu samo na količinu sastojaka, već i na vrstu jela. Ne znam postoji li kuharica s receptima za velike lonce, ali ne bi bilo na odmet promisliti! Već desetak godina volontiram u jednoj pučkoj kuhinji, u kojoj se priprema hrana za newyorške beskućnike. Moram priznati da me, osim osjećaja da radim nešto korisno za druge, privukla kuhinja opremljena poput restorana i prvenstveno - lonci. Skladište u kojem se nalaze ogromni lonci, poklopci, cjediljke, tave, zdjele, volim nazivati «garažom»!",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    IsTranslated = true,
                    KeyWords = "lonac",
                    ModifiedAt = DateTime.Now,
                    CreateUserId = adminId
                });
            }

            if (!context.Article.Any(x => x.Title == "Božićni kolači bez roka trajanja"))
            {
                context.Article.Add(new Article
                {
                    Title = "Božićni kolači bez roka trajanja",
                    Content = "Uživajte u okusima i mirisima starinskih blagdanskih slastica koji nas vraćaju u prošlost i bude sjećanja na naše najmilije, mame, bake i prabake.\nU vrijeme Adventa, razdoblja koje prethodi Božiću, baš kao i stoljećima ranije, u našim domovima vlada slatka groznica. Pretražujmo internet, listamo kuharice i stare umrljane teke i biramo recepte za blagdanske kolače. Kupujemo najfinije sastojke, čokoladu, orahe, bademe, lješnjake, marcipan, sušeno voće i aromatične začine - vaniliju, cimet, anis, klinčiće… A kako ničega ne smije nedostajati, tu je i malo brdo pakiranja s kvascem, želatinom, praškom za pecivo, vanilin šećerom i šećerima aromatiziranih limunom, narančom i rumom.\nBez obzira na naše moderne kuhinje i iskustvo, među našim blagdanskim kolačima, uvijek mora biti i pokoja starinska slastica u kojoj smo uživali u domovima naših mama, baka i prabaka. ",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    IsTranslated = false,
                    KeyWords = "božić, kolači",
                    ModifiedAt = DateTime.Now,
                    CreateUserId = adminId
                });
            }

            context.SaveChanges();
            #endregion

            #region ARTICLE TRANSLATION

            var clanak1Prevodom = context.Article.First(x => x.Title == "Danas imamo sladoled za doručak!").Id;
            var clanak2Prevodom = context.Article.First(x => x.Title == "Kuhati u velikim loncima").Id;

            if (!context.ArticleTranslation.Any(x => x.Title == "Danas imamo sladoled za doručak!"))
            {
                context.ArticleTranslation.Add(new ArticleTranslation
                {
                    Title = "Today we have ice cream for breakfast!",
                    Content = "In the 1960s, in snow-covered Rochester, upstate New York, a mother of six thought she was going crazy, so she invented breakfast ice cream. \n Florence was desperate. , in New York State, the temperature was polar, and her six children did not want to hear that she was engaged in peaceful activities such as drawing, chess, reading, playing cards. Monday, and going to school, seemed an unattainable illusion. She needed to come up with something urgent. \n We have ice cream for breakfast today!, magic words were enough to cause silence.",
                    ArticleId = clanak1Prevodom,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    KeyWords = "ice cream",
                    ModifiedAt = DateTime.Now,
                });
            }

            if (!context.ArticleTranslation.Any(x => x.Title == "Kuhati u velikim loncima"))
            {
                context.ArticleTranslation.Add(new ArticleTranslation
                {
                    Title = "Cook in large pots",
                    Content= "Enjoy the flavors and aromas of antique holiday sweets that take us back to the past and bring back memories of our loved ones, moms, grandparents. \nAt Advent, the pre-Christmas period, just like centuries earlier, our homes are sweet Let's browse the internet, browse cookbooks and old stained appetizers and choose recipes for holiday cakes We buy the finest ingredients, chocolate, nuts, almonds, hazelnuts, marzipan, dried fruit and aromatic spices - vanilla, cinnamon, anise, cloves… And how come nothing may be missing, there is a small hill of packaging with yeast, gelatin, baking powder, vanilla sugar and sugars flavored with lemon, orange and rum. \n Regardless of our modern cuisines and experience, among our holiday cakes, there must always be a few old a dessert that we enjoyed in the homes of our mothers, grandmothers and great-grandmothers.",
                    ArticleId = clanak2Prevodom,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    KeyWords = "pot",
                    ModifiedAt = DateTime.Now,
                });
            }

            context.SaveChanges();
            #endregion

            #region RECIPE

            if (!context.Recipe.Any(x => x.Title == "Medenjaci"))
            {
                context.Recipe.Add(new Recipe
                {
                    Title = "Medenjaci",
                    Ingredients = "160 grama meda\n120 grama maslaca\n350 grama glatkog brašna\n100 grama šećera u prahu\n20 grama začin(cimet, đumbir, anis, klinčić)\n5 grama pzp\n1 kom jaje",
                    Introduction = "Ukusno i jednostavno",
                    Method = "Na laganoj vatri rastopiti i povezati maslac i med. paziti da ne uzavrije\nPomiješati brašno, šećer, začine, PZP te jaje. Dodajte i rastopljeni maslac i med. Sve zajedno promiješajte u mikseru.\nSpremiti dobivenu smjesu u hladnjak (zamotati i prozirnu foliju)\npobrašnici površinu, pobrašniti tijesto i razvaljati\nPeći na 180 C 8 minuta.",
                    Advice = "",
                    Serving = "Poslužiti uz šoljicu kafe :)",
                    MealType = 1,
                    PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 0, 0),
                    PreparationTimeCategory = 2,
                    WeightOfPreparation = 1,
                    IsApproved = true,
                    IsRead = true,
                    IsSent = false,
                    IsTranslated = true,
                    //Picture=,
                    UserId = adminId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            if (!context.Recipe.Any(x => x.Title == "Italijanski hljeb"))
            {
                context.Recipe.Add(new Recipe
                {
                    Title = "Italijanski hljeb",
                    Introduction = "Tako jednostavan a ukusan.",
                    Ingredients = "400 g brasna\n1 kasika kvasca\n2 Male kasike soli\n280 ml mlake vode\n1 mala kasika secera\n2 velike kasike ulja",
                    Method = "Staviti Brasno u posudu u kojoj ce Vam mirovati Tjesto. Napraviti udubljenje i tu usuti 50 ml Tople Vode i Kvasac dodati. Malo izmjesati i ostaviti da miruje 10 Minuta.\nSad dodati Ostalu vodu  i sve umjesiti da se fino sjedini. Na Damon kraju dodati ulje i kasikom naglo izmjesati, oko pola Minute. Ostaviti na toplom da se udvostruci volumen.\nPripremiti pleh oblozen sa papirom za pecenje. Tjesto izruciti na pobrasnjenu povrsinu i Oblikovati Kao na slici, paziti da sto manje mjesite. Samo istresite tjesto i sa strana malo poklopite, toliko da se ne ljepi i odmah na pleh stavljati. Pustiti 20 Minuta da miruje.",
                    Advice = "Pecnicu ukljuciti da se zagrije na 210 Stepeni. Hleb premazati sa Malo vode i posuti sa brasnom. Peci 20 Minuta dok fino ne porumeni.",
                    Serving = "",
                    MealType = 7,
                    PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 10, 0),
                    PreparationTimeCategory = 3,
                    WeightOfPreparation = 2,
                    IsApproved = false,
                    IsRead = false,
                    IsSent = true,
                    IsTranslated = false,
                    //Picture=,
                    UserId = korisnikId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            if (!context.Recipe.Any(x => x.Title == "Krem juha od bundeve"))
            {
                context.Recipe.Add(new Recipe
                {
                    Title = "Krem juha od bundeve",
                    Introduction = "Krem juha od bundeve, u domaćoj pripremi, dobar je uvod za vaš jesenji ručak pun aroma i izazova za vaše nepce.",
                    Ingredients = "1 manja butternut bundeva\n2 dcl vrhnja za kuhanje\n3 - 4 mrkve\n1 glavica crvenog luka\n1 korijen peršina\nmanji komad celera\njuha u kocki ili vegeta\n4 kriške kruha\n2 režnja češnjaka\nmaslinovo ulje",
                    Method = " Na maslinovom ulju popržite sitno sjeckani crveni luk. Na sitnije komade izrežite bundevu, mrkvu, peršin i celer. Na blago poprženi luk dodajte povrće koje ste prethodno izrezali na manje komade. Zalijte vodom tako da prekrije povrće i kuhajte to na lagano 25-30 minuta. U ovoj fazi možete se zabaviti pripremom krutona.\nKada povrće omekani, štapnim mikserom ili na drugi način usitnite sav skuhani sadržaj, dodajte juhu u kocki, 2 dcl vrhnja za kuhanje i vode po želji. Krenite s manjim količina vode pa po želji dodajte još kako bi izradili gustoću kakva vam odgovara.",
                    Serving = "Vašu gotovu juhu poslužite u dubokom tanjuru ili zdjelici te aranžirajte uz par kapi vrhnja za kuhanje i sitno sjeckani peršinov list. Na površinu juhe žlicom nanesite pripremljene krutone.",
                    Advice = "Juhu možete dodatno začiniti kajenskim paprom.\nDobar tek!",
                    MealType = 5,
                    PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 40, 0),
                    PreparationTimeCategory = 2,
                    WeightOfPreparation = 1,
                    IsApproved = true,
                    IsRead = true,
                    IsSent = true,
                    IsTranslated = true,
                    //Picture=,
                    UserId = korisnikId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            if (!context.Recipe.Any(x => x.Title == "Tulumbe"))
            {
                context.Recipe.Add(new Recipe
                {
                    Title = "Tulumbe",
                    Introduction = "Najbolji recept za tulumbe koji ćete pronaći.",
                    Ingredients = "4 jaja\ncasa vode\ncasa mlijeka\n2 case brasna\nmala kasikica praska\nAGDA:\n10 soljica secera\n8 soljica vode",
                    Method = "Secer i vodu za agdu staviti da prokuha i kuha oko 5 min.ostaviti da se ohladi\nMlijeko vodu i ulje za tijesto staviti da prokuha i u to dodati brasno i prasak.smanjiti temperaturu idobro ukuhati dok nedobijemo finu masu .ostaviti da se prohlad\nTjesto sipati u kalup i tulumbe izvlaciti u mlako ulje znaci ne u vrelo.I onda pojacat temperaturu na nelu srednju jacinu\nU prohladenu masu dodavati jedno po jedno jaje i dobro mjesati.\nPoslije svkog przenja ulje malo prohladiti za sljedecu turu przenja\nPrzene tulumbe prohladiti pa ih onda stavit  takoder u hladnu agdu.",
                    Advice = "Ostaviti par sati da se dobro upiju\nDobar tek!",
                    Serving = "Odlične uz šoljicu kafe.",
                    MealType = 1,
                    PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 40, 0),
                    PreparationTimeCategory = 3,
                    WeightOfPreparation = 3,
                    IsApproved = true,
                    IsRead = true,
                    IsSent = false,
                    IsTranslated = false,
                    //Picture=,
                    UserId = adminId,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            context.SaveChanges();
            #endregion

            #region RECIPE TRANSLATION

            var saPrevodom = context.Recipe.First(x => x.Title == "Medenjaci").Id;
            var bezPrevoda = context.Recipe.First(x => x.Title == "Tulumbe").Id;
            var spremljenSaPrevodom = context.Recipe.First(x => x.Title == "Krem juha od bundeve").Id;
            var spremljenBezPrevoda = context.Recipe.First(x => x.Title == "Italijanski hljeb").Id;


            if (!context.RecipeTranslation.Any(x => x.RecipeId == saPrevodom))
            {
                context.RecipeTranslation.Add(new RecipeTranslation
                {
                    Title = "Gingerbreads",
                    Introduction = "Delicious and easy",
                    Ingredients = "160 grams of honey \n 120 grams of butter \n 350 grams of plain flour \n 100 grams of powdered sugar \n 20 grams of spice (cinnamon, ginger, anise, clove) \n 5 grams of pzp \n 1 egg",
                    Method = "Melt the butter and honey over a low heat. Be careful not to boil \nMix the flour, sugar, spices, PZP and egg. Add the melted butter and honey. Mix everything together in a mixer. \nSave the resulting mixture in the refrigerator (wrap and cling film) \nflour the surface, flour the dough and roll out \nBake at 180 C for 8 minutes.",
                    Serving = "Serve with a cup of coffee :)",
                    Advice = "",
                    RecipeId = saPrevodom,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            if (!context.RecipeTranslation.Any(x => x.RecipeId == spremljenSaPrevodom))
            {
                context.RecipeTranslation.Add(new RecipeTranslation
                {
                    Title = "Pumpkin cream soup",
                    Introduction = "Pumpkin cream soup, homemade, is a good introduction to your autumn lunch full of aromas and challenges for your palate",
                    Ingredients = "1 small pumpkin butternut\n 2 dcl cooking cream\n 3 - 4 carrots \n 1 red onion \n 1 parsley root \n small piece of celery \n diced or vegeta \n 4 slices of bread \n 2 garlic cloves \n olive oil",
                    Method = "Fry finely chopped red onion in olive oil. Cut pumpkin, carrot, parsley and celery into smaller pieces. Add vegetables that you previously cut into smaller pieces to lightly fried onions. Pour water so that it covers the vegetables and cook it lightly 25 -30 minutes At this stage you can have fun preparing croutons. \n When the vegetables are softened, chop all the cooked contents with a stick mixer or otherwise, add the diced soup, 2 dcl of cooking cream and water as desired. add more if desired to create a density that suits you.",
                    Serving = "Serve your finished soup in a deep plate or bowl and arrange with a few drops of cooking cream and finely chopped parsley leaf. Spoon the prepared croutons onto the surface of the soup",
                    Advice = "You can spice up the soup with cayenne pepper. \n Good taste!",
                    RecipeId = spremljenSaPrevodom,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                });
            }

            context.SaveChanges();

            #endregion

            #region USER FAVOURITE RECIPE

            if (!context.UserFavouriteRecipe.Any(x => x.RecipeId == spremljenSaPrevodom && x.UserId == zaposlenikId))
            {
                context.UserFavouriteRecipe.Add(new UserFavouriteRecipe
                {
                    UserId = zaposlenikId,
                    RecipeId = spremljenSaPrevodom,
                    IsDeleted = false,
                });
            }

            if (!context.UserFavouriteRecipe.Any(x => x.RecipeId == spremljenSaPrevodom && x.UserId == korisnikId))
            {
                context.UserFavouriteRecipe.Add(new UserFavouriteRecipe
                {
                    UserId = korisnikId,
                    RecipeId = spremljenSaPrevodom,
                    IsDeleted = false,
                });
            }

            if (!context.UserFavouriteRecipe.Any(x => x.RecipeId == spremljenSaPrevodom && x.UserId == korisnikTestId))
            {
                context.UserFavouriteRecipe.Add(new UserFavouriteRecipe
                {
                    UserId = korisnikTestId,
                    RecipeId = spremljenSaPrevodom,
                    IsDeleted = false,
                });
            }

            if (!context.UserFavouriteRecipe.Any(x => x.RecipeId == bezPrevoda && x.UserId == adminId))
            {
                context.UserFavouriteRecipe.Add(new UserFavouriteRecipe
                {
                    UserId = adminId,
                    RecipeId = bezPrevoda,
                    IsDeleted = false,
                });
            }

            context.SaveChanges();

            #endregion

            #region USER RECIPE RATING

            if (!context.UserRecipeRating.Any(x => x.RecipeId == bezPrevoda && x.UserId == adminId))
            {
                context.UserRecipeRating.Add(new UserRecipeRating
                {
                    UserId = adminId,
                    RecipeId = bezPrevoda,
                    Rating = 4,
                    IsDeleted = false,
                });
            }

            if (!context.UserRecipeRating.Any(x => x.RecipeId == saPrevodom && x.UserId == korisnikId))
            {
                context.UserRecipeRating.Add(new UserRecipeRating
                {
                    UserId = korisnikId,
                    RecipeId = saPrevodom,
                    Rating = 4,
                    IsDeleted = false,
                });
            }

            if (!context.UserRecipeRating.Any(x => x.RecipeId == saPrevodom && x.UserId == zaposlenikId))
            {
                context.UserRecipeRating.Add(new UserRecipeRating
                {
                    UserId = zaposlenikId,
                    RecipeId = saPrevodom,
                    Rating = 2,
                    IsDeleted = false,
                });
            }

            if (!context.UserRecipeRating.Any(x => x.RecipeId == spremljenSaPrevodom && x.UserId == zaposlenikId))
            {
                context.UserRecipeRating.Add(new UserRecipeRating
                {
                    UserId = zaposlenikId,
                    RecipeId = spremljenSaPrevodom,
                    Rating = 5,
                    IsDeleted = false,
                });
            }

            if (!context.UserRecipeRating.Any(x => x.RecipeId == spremljenSaPrevodom && x.UserId == korisnikTestId))
            {
                context.UserRecipeRating.Add(new UserRecipeRating
                {
                    UserId = korisnikTestId,
                    RecipeId = spremljenSaPrevodom,
                    Rating = 5,
                    IsDeleted = false,
                });
            }

            context.SaveChanges();

            #endregion

            #region FOLLOW

            if (!context.Follow.Any(x => x.UserId == zaposlenikId && x.FollowerId == korisnikId))
            {
                context.Follow.Add(new Follow
                {
                    UserId = zaposlenikId,
                    FollowerId = korisnikId,
                });
            }

            if (!context.Follow.Any(x => x.UserId == adminId && x.FollowerId == korisnikId))
            {
                context.Follow.Add(new Follow
                {
                    UserId = adminId,
                    FollowerId = korisnikId,
                });
            }

            if (!context.Follow.Any(x => x.UserId == adminId && x.FollowerId == zaposlenikId))
            {
                context.Follow.Add(new Follow
                {
                    UserId = adminId,
                    FollowerId = zaposlenikId,
                });
            }

            if (!context.Follow.Any(x => x.UserId == korisnikId && x.FollowerId == korisnikTestId))
            {
                context.Follow.Add(new Follow
                {
                    UserId = korisnikId,
                    FollowerId = korisnikTestId,
                });
            }

            if (!context.Follow.Any(x => x.UserId == korisnikTestId && x.FollowerId == korisnikId))
            {
                context.Follow.Add(new Follow
                {
                    UserId = korisnikTestId,
                    FollowerId = korisnikId,
                });
            }

            context.SaveChanges();

            #endregion

            #region FEEDBACK

            if (!context.Feedback.Any(x => x.UserId == adminId && x.Description == "Odlično"))
            {
                context.Feedback.Add(new Feedback
                {
                    UserId = adminId,
                    Description = "Odlično",
                    Rating = 5,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                });
            }

            if (!context.Feedback.Any(x => x.UserId == zaposlenikId && x.Description == "Odlično"))
            {
                context.Feedback.Add(new Feedback
                {
                    UserId = zaposlenikId,
                    Description = "Super",
                    Rating = 4,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                });
            }

            context.SaveChanges();
            #endregion

            #region COMMENTS

            if (!context.Comment.Any(x => x.UserId == zaposlenikId && x.RecipeId == saPrevodom))
            {
                context.Comment.Add(new Comment
                {
                    UserId = zaposlenikId,
                    RecipeId = saPrevodom,
                    ModifiedAt = DateTime.Now,
                    Description = "Super",
                    IsDeleted = false,
                });
            }

            if (!context.Comment.Any(x => x.UserId == adminId && x.RecipeId == saPrevodom))
            {
                context.Comment.Add(new Comment
                {
                    UserId = adminId,
                    RecipeId = saPrevodom,
                    ModifiedAt = DateTime.Now,
                    Description = "Super recept",
                    IsDeleted = false,
                });
            }

            context.SaveChanges();

            #endregion
           
        }
    }
}
