using FakeItEasy;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pragma.Tests.Repository
{
    public class SimpleRepositoryTest
    {
        public int QtdGenerate = 10;
        public IList<TestModel> Data { get; set; }

        public ISimpleRepository<TestModel> Repository;

        protected void GenerateFakeData()
        {
            Data = TestModel.GetData().ToList();

        }

        public SimpleRepositoryTest()
        {
            var context = A.Fake<BaseContext>(e => e.WithArgumentsForConstructor(new object[] { "xxxxxxxx" }));

            GenerateFakeData();
            Aef.Configure(context, Data);
            Repository = new SimpleRepository<TestModel>(context);

        }

        [Fact(DisplayName = "[DAO_FW] Should return all items of dataset")]
        public void GetTest()
        {
            var result = Repository.Get();

            Assert.True(result.Count() == Data.Count());
        }

        [Fact(DisplayName = "[DAO_FW] Should return async all items of dataset")]
        public async void GetAsyncTest()
        {
            var result = await Repository.GetAsync();

            Assert.True(result.Count() == Data.Count());
        }

        [Fact(DisplayName = "[DAO_FW] Should return top 3 items of dataset")]
        public void GetTopTest()
        {
            var result = Repository.Get(3).ToList();

            var equal = true;

            for (int i = 0; i < 3; i++)
                equal &= (result[i] == Data[i]);

            Assert.True(result.Count() == 3 && equal);
        }

        [Fact(DisplayName = "[DAO_FW] Should return async top 3 items of dataset")]
        public async void GetTopAsyncTest()
        {
            var result = (await Repository.GetAsync(3)).ToList();

            var equal = true;

            for (int i = 0; i < 3; i++)
                equal &= (result[i] == Data[i]);

            Assert.True(result.Count() == 3 && equal);
        }


        [Fact(DisplayName = "[DAO_FW] Should order items of dataset")]
        public void GetOrderedTest()
        {
            var result = Repository.Get(order: e => e.OrderByDescending(x => x.Id)).ToList();

            Assert.Equal(result.First(), Data.Last());
        }


        [Fact(DisplayName = "[DAO_FW] Should filter items in dataset")]
        public void GetFilteredTest()
        {
            var result = Repository.Get(where: e => e.Property == "Banana").FirstOrDefault();

            Assert.True(result.Property == "Banana");
        }

        [Fact(DisplayName = "[DAO_FW] Should count items in dataset")]
        public void CountTest()
        {
            var result = Repository.Count();

            Assert.Equal(result, Data.Count());
        }


        [Fact(DisplayName = "[DAO_FW] Should Sum items in dataset")]
        public void SumTest()
        {
            var result = Repository.Sum(e => e.Id < 3, e => e.Id);

            Assert.Equal(result, Data[0].Id + Data[1].Id);
        }

        [Fact(DisplayName = "[DAO_FW] Should Get max Id in dataset")]
        public void maxTest()
        {
            var result = Repository.Max(e => e.Id);

            Assert.Equal(result, 10);
        }


        [Fact(DisplayName = "[DAO_FW] Should Get min Id in dataset")]
        public void MinTest()
        {
            var result = Repository.Min(e => e.Id);

            Assert.Equal(result, 1);
        }


        [Fact(DisplayName = "[DAO_FW] Should Add item in dataset")]
        public void AddTest()
        {

            var item = new TestModel { Id = 11, Property = "Fruit" };

            Repository.Add(item);

            var result = Repository.Get().ToList();

            Assert.True(result.Any(e => e.Property == item.Property && e.Id == item.Id));
        }


        [Fact(DisplayName = "[DAO_FW] Should remove item in dataset")]
        public void RemoveTest()
        {

            var item = Repository.Get(order: o => o.OrderByDescending(i => i.Id)).FirstOrDefault();

            Repository.Remove(item);

            var result = Repository.Get().ToList();

            Assert.True(!result.Any(e => e.Property == item.Property && e.Id == item.Id));
        }

        [Fact(DisplayName = "[DAO_FW] Should filter all filds in dataset")]
        public void FilterAllTest()
        {


            var result = Repository.FindAllProperties("erry").ToList();

            Assert.Equal(result.Count(), 3);
        }

    }
}
