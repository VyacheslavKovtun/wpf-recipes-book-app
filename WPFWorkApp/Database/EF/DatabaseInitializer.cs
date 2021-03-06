using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Database.Entities;
using RecipesBook.Database.Repository;
using RecipesBook.Models.Database.Context;
using RecipesBook.Models.Database.Entities;
using RecipesBook.Models.Database.Repository;

namespace RecipesBook.Models.Database.Base
{
    public class DatabaseInitializer:DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext ctx)
        {
            FillCategories();
            FillRecipes();
        }

        private void FillRecipes()
        {
            RecipeRepository recipeRepos = new RecipeRepository();
            CategoryRepository categoryRepos = new CategoryRepository();

            recipeRepos.Add(new Recipe
            {
                Id = 0,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/66/sm_65699.jpg",
                Name = "Борщ",
                Ingredients = "Говядина - 500 г\nКартофель - 500 г\nКапуста белокочанная - 500 г\nСвекла - 300 г" +
                "\nМорковь - 300 г\nЛук репчатый - 2 шт.\nТомат - паста - 2 ст.ложки\nЧернослив - 5 шт." +
                "\nЗелень петрушки - 1 пучок\nСоль - 0,5 - 1 ст.ложка(по вкусу)\nМасло растительное - 2 ст.ложки" +
                "\nВода - 2 л\nСметана(для подачи) - по вкусу",
                CookingInstruction = "Подготавливают все необходимые продукты. Если чернослив сухой, заливают его кипятком на 10-15 минут.\n" +
                "Мясо нарезают небольшими кусочками.\n" +
                "Выкладывают мясо в кастрюлю, заливают холодной водой. Доводят до кипения, снимают пену и варят мясо 1,5 часа на маленьком огне, под крышкой.\n" +
                "Картофель очищают и нарезают крупными кусками.\n" +
                "Свеклу очищают, нарезают соломкой. Обычно свёклу тушат в сковороде с добавлением лимонного сока или уксуса - можно сделать именно так. Но в этом рецепте свёкла добавляется в бульон в сыром виде и варится вместе с картошкой и капустой.\n" +
                "Капусту шинкуют соломкой.\n" +
                "Лук чистят и мелко нарезают.\n" +
                "Морковь чистят и натирают на крупной терке.\n" +
                "Чернослив очищают от косточек, мелко нарезают.\n" +
                "Сковороду нагревают, наливают растительное масло. В горячее масло выкладывают лук и морковь, обжаривают овощи, помешивая, 3-4 минуты на среднем огне. Добавляют томатную пасту, перемешивают и обжаривают овощи с томатом ещё 1 минуту.\n" +
                "В мясной бульон добавляют картофель, свёклу, капусту, обжаренные лук и морковь. Добавляют чернослив, соль и варят борщ с черносливом до готовности картофеля, 20-25 минут.\n" +
                "Зелень моют и мелко режут.\n" +
                "Готовый борщ с черносливом разливают по тарелкам, посыпают измельченной зеленью петрушки. Подают борщ со сметаной. Приятного аппетита!",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 1)
            });

            recipeRepos.Add(new Recipe
            {
                Id = 1,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/11/sm_10976.jpg",
                Name = "Окрошка",
                Ingredients = "квас для окрошки хлебный	1.5	л\nмясо отварное(говядина) 300 г\nогурцы 3 - 4 шт.\n" +
                "картофель 4 шт.\nяйца  4 шт.\nлук зелёный  10 - 15 г\nзелень укропа  10 г\nзелень петрушки   10 г\n" +
                "сметана  2 стакана\nсоль(по вкусу) 0.5 ч.ложки\nсахар(по вкусу)  0.25 ч.ложки\nгорчица(соус)  0.5 ч.ложки",
                CookingInstruction = "Картофель с яйцами (яйца можно варить отдельно, это по желанию) сложить в кастрюлю, залить холодной водой и поставить на средний огонь. Довести до кипения, уменьшить огонь и варить 8-10 минут. Вынуть яйца, переложить в холодную воду, а картофель продолжить варить до мягкости, еще минут 10.\n" +
                "Пока варятся яйца и картофель, нарезать отварное мясо кубиками.\n" +
                "Укроп мелко порубить\n" +
                "Петрушку также мелко порубить.\n" +
                "Огурцы порезать мелкими кубиками.\n" +
                "Зеленый лук мелко нарезать.\n" +
                "Нарезанный зеленый лук растереть с небольшим количеством соли, до тех пор, пока не появится сок.\n" +
                "Яйца почистить и порезать кубиками.\n" +
                "Готовый картофель переложить в холодную воду на пару минут, а затем достать из воды, почистить и порезать кубиками.\n" +
                "Все нарезанные ингредиенты, кроме петрушки и укропа, соединить в большой кастрюле или миске. (При желании можно добавить в окрошку нарезанный редис.) Заправить сметаной и хорошо перемешать.\n" +
                "Залить квасом. Добавить укроп, петрушку, сахар, горчицу, посолить и перемешать.\n" +
                "Для любителей кисленького можно подать окрошку с долькой лимона.",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 1)
            });

            recipeRepos.Add(new Recipe
            {
                Id = 2,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/206/sm_205203.jpg",
                Name = "Голубцы",
                Ingredients = "Капуста белокочанная - 1 шт.\nРис - 1 стакан\nФарш мясной - 500 г\n" +
                "Морковь - 1 шт.\nЛук репчатый - 4 - 5 шт.\nКетчуп или томатный соус - 3 ст.л.\n" +
                "Масло растительное - для жарки\nПерец молотый(красный и черный)\nСахар\nСоль",
                CookingInstruction = "Подготовим капустные листья для голубцов.\n" +
                "Измельчим лук и морковь.\n" +
                "Поджарим овощи на растительном масле до готовности и разделим на две части. Одну часть используем для начинки. Во вторую часть добавим соль (1 ст. л.), сахар (1 ст. л.), молотый перец и томатный соус или кетчуп.\n" +
                "Немного обжарим овощи с томатом, дольем воду (2-3 стакана) и закипятим томатную подливу.\n" +
                "Смешаем сваренный заранее рис, фарш и овощную зажарку. Начинку для голубцов посолим, поперчим и перемешаем.\n" +
                "Закрутим голубцы с мясом и рисом.\n" +
                "Голубцы выложим в кастрюлю и зальем томатной подливой.\n" +
                "Готовим голубцы на небольшом огне примерно 1 час.",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 2)
            });

            recipeRepos.Add(new Recipe
            {
                Id = 3,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/159/sm_158503.jpg",
                Name = "Котлеты",
                Ingredients = "Фарш мясной - 500 г\nЯйцо(желток) - 1 шт.\nЛук репчатый - 1 шт.\n" +
                "Хлеб белый(мякоть) - 80 г\nМолоко - 50 г\nСоль - 1 ч.ложка\nПерец молотый - 0,25 ч.ложки\n" +
                "Масло растительное для жарки - 30 мл(или сколько уйдет)",
                CookingInstruction = "Для домашних котлет из фарша сперва хлеб замочить в молоке (без корочки).\n" +
                "Фарш поместить в миску. Лук очистить, натереть на мелкой терке, добавить к фаршу. Выложить в миску с фаршем размоченный хлеб. Добавить желток. Фарш хорошо перемешать до однородности и отбить.\n" +
                "Мокрыми руками сформировать котлеты из фарша.Разогреть сковороду, налить растительное масло. В горячее масло выложить котлеты. Жарить котлеты на среднем огне до золотистости с двух сторон.\n" +
                "Домашние котлеты из фарша выложить в казанок, налить 2-3 ст. ложки кипятка. Поставить на огонь, накрыть крышкой. Тушить на самом минимальном огне 10 минут.\n" +
                "Домашние котлеты из фарша готовы. Подавать мясные котлеты с любимым гарниром или овощным салатом. Приятного аппетита!",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 2)
            });

            recipeRepos.Add(new Recipe
            {
                Id = 4,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/137/sm_136343.jpg",
                Name = "Бургер",
                Ingredients = "Булочки для бургера - 3 шт.\nФарш мясной - 400 г\nСыр твердый - 30 - 50 г\n" +
                "Помидор - 1 - 2 шт.\nОгурец соленый - 1 шт.\nЛук синий(фиолетовый) - 1 шт.\n" +
                "Салатные(капустные) листья - 5 - 6 шт.\nМайонез - 2 ч.л.\nКетчуп(любой) - 2 ч.л.\n" +
                "Перец черный - по вкусу\nСоль - по вкусу\nМасло подсолнечное - для жарки",
                CookingInstruction = "В мясной фарш добавляем соль и перец по вкусу, хорошо вымешиваем. Формируем шарик, расплющиваем его в руках, чтобы получилась плоская котлета. Надавливаем большим пальцем в центр котлеты, чтобы она не вздулась во время обжаривания.\n" +
                "Обжариваем котлету 4-5 минут с каждой стороны. На готовую котлету кладем тонкий кусочек сыра.\n" +
                "Помидоры нарезаем кружочками, твердый сыр - тонкими пластинами, соленый огурец - тонкими кружочками. В отдельной емкости смешиваем майонез и кетчуп.\n" +
                "Булочку разрезаем пополам и смазываем соусом из майонеза и кетчупа.\n" +
                "Выкладываем на соус порванный руками листья салата (капусты).\n" +
                "На салат кладем нарезанный тонкими колечками лук.\n" +
                "На лук выкладываем кружочек помидора.\n" +
                "На кружочек помидора выкладываем котлету.\n" +
                "На котлету выкладываем пару ломтиков соленого огурца и ломтик сыра.\n" +
                "Накрываем бургер второй частью булочки. По такому же принципу формируем остальные бургеры.",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 3)
            });

            recipeRepos.Add(new Recipe
            {
                Id = 5,
                ImagePath = "https://img1.russianfood.com/dycontent/images_upl/327/sm_326293.jpg",
                Name = "Чипсы",
                Ingredients = "Картофель\nМасло растительное для фритюра\nСоль\nСпеции(по желанию)",
                CookingInstruction = "Для приготовления чипсов нам понадобится, конечно, картошка, а также растительное масло и соль. Кроме того, можно взять любые специи и приправы.\n" +
                "Картошку чистим, моем, очень тонко режем - толщина ломтиков примерно 2 мм. Очень удобно, если под рукой есть специальная терка, но можно нарезать такие ломтики ножом для чистки картофеля. Или обычным ножом.\n" +
                "В казанке хорошо разогреваем растительное масло. Опускаем в масло порцию картофельных ломтиков. Не нужно жарить сразу все - ломтики должны свободно плавать в масле! Внимание! Масло начнет сильно бурлить и подниматься шапкой.Будьте осторожны и следите, чтобы оно не перелилось через край.\n" +
                "Жарим ломтики картошки во фритюре до золотистого цвета (примерно 3 минуты). Нужно следить, чтобы ломтики не слиплись - переворачивать их, разделять, если они все-таки слиплись.\n" +
                "Готовые картофельные чипсы выкладываем на салфетку, чтобы впиталось лишнее масло.\n" +
                "Добавляем соль. Можно добавить любые сухие специи. Встряхиваем. Домашние чипсы готовы. Чипсы, конечно, не диетическая еда, но иногда так хочется побаловать себя вкусненьким.Приятного аппетита!",
                Category = categoryRepos.GetAll().FirstOrDefault(c => c.Id == 3)
            });
        }

        private void FillCategories()
        {
            CategoryRepository categoryRepos = new CategoryRepository();

            categoryRepos.Add(new Category
            {
                Id = 0,
                Name = "Первые блюда"
            });

            categoryRepos.Add(new Category
            {
                Id = 1,
                Name = "Вторые блюда"
            });

            categoryRepos.Add(new Category
            {
                Id = 2,
                Name = "Закуски"
            });
        }
    }
}
