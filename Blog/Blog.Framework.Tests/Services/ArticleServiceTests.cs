using Autofac.Extras.Moq;
using Blog.Framework.Entities;
using Blog.Framework.Repositories.Articles;
using Blog.Framework.Services.Articles;
using Blog.Framework.UnitOfWorks.Articles;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace Blog.Framework.Tests.Services
{
    [ExcludeFromCodeCoverage]
    public class ArticleServiceTests
    {
        private readonly AutoMock _mock;
        private readonly Mock<IArticleRepository> _articleRepositoryMock;
        private readonly Mock<IArticleUnitOfWork> _articleUnitOfWorkMock;
        private readonly IArticleService _articleService;
        public ArticleServiceTests()
        {
            _mock = AutoMock.GetLoose();
            _articleRepositoryMock = _mock.Mock<IArticleRepository>();
            _articleUnitOfWorkMock = _mock.Mock<IArticleUnitOfWork>();
            _articleService = _mock.Create<ArticleService>();
        }

        public void Dispose()
        {
            _articleRepositoryMock.Reset();
            _articleUnitOfWorkMock.Reset();

            _mock?.Dispose();
        }

        [Fact]
        public void GetAll_TakesNothing_ReturnsListOfArticles()
        {
            //Arrange
            IList<Article> articles = new List<Article>
            {
                new Article{
                    Title = "MVC5 CRUD",
                    Descreption = "nHibernate can be used for data access"
                },
                new Article{
                    Title = "PHP CRUD",
                    Descreption = "nHibernate can be used for data access"
                }
            };
                

            //Act
            _articleUnitOfWorkMock.Setup(x => x.ArticleRepository)
                .Returns(_articleRepositoryMock.Object);

            _articleRepositoryMock.Setup(x => x.GetAll())
                .Returns(articles)
                .Verifiable();
            
            var articleList = _articleService.GetAll();

            //Assert
            _articleRepositoryMock.VerifyAll();
            _articleUnitOfWorkMock.VerifyAll();
            Should.Equals(articles,articleList);
        }


        [Fact]
        public void GetByCategoryId_TakesCategoryId_ReturnsListOfArticles()
        {
            //Arrange
            IList<Article> articles = new List<Article>
            {
                new Article{
                    Title = "MVC5 CRUD",
                    Descreption = "nHibernate can be used for data access"
                },
                new Article{
                    Title = "PHP CRUD",
                    Descreption = "nHibernate can be used for data access"
                }
            };

            int CategoryId = 1;

            Article article = new Article { CategoryId= 1, Title = "Article Tittle", Descreption = "Descriptions ......" };


            //Act
            _articleUnitOfWorkMock.Setup(x => x.ArticleRepository)
                .Returns(_articleRepositoryMock.Object);

            _articleRepositoryMock.Setup(x => x.Get(
                It.Is<Expression<Func<Article, bool>>>(y => y.Compile()(article))))
                .Returns(articles).Verifiable();

            IList<Article> articlesList = _articleService.GetByCategoryId(CategoryId);

            //Assert
            _articleRepositoryMock.VerifyAll();
            _articleUnitOfWorkMock.VerifyAll();
            articles.ShouldBe(articlesList);
        }
    }
}
