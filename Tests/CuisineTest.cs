using Xunit;
using System;
using System.Collections.Generic;
using Review.Objects;

namespace Review
{
  public class CuisineTest : IDisposable
  {
    public CuisineTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=review_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      int result = Cuisine.GetAll().Count;

      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_Equal_ReturnsTrueIfNamesAreTheSame()
    {
      Cuisine firstCuisine = new Cuisine("Pizza");
      Cuisine secondCuisine = new Cuisine("Pizza");

      Assert.Equal(firstCuisine, secondCuisine);
    }

    [Fact]
    public void Test_Save_SavesToDatabase()
    {
      Cuisine testCuisine = new Cuisine("Pizza");

      testCuisine.Save();
      List<Cuisine> result = Cuisine.GetAll();
      List<Cuisine> testList = new List<Cuisine>{testCuisine};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Cuisine testCuisine = new Cuisine("Pizza");

      testCuisine.Save();
      Cuisine savedCuisine = Cuisine.GetAll()[0];

      int result = savedCuisine.GetId();
      int testId = testCuisine.GetId();

      Assert.Equal(testId, result);
    }

    [Fact]
    public void Test_Find_FindsRestaurantInDatabase()
    {
      Cuisine testCuisine = new Cuisine("Pizza");
      testCuisine.Save();
      Cuisine foundCuisine = Cuisine.Find(testCuisine.GetId());

      Assert.Equal(testCuisine, foundCuisine);
    }

    public void Dispose()
    {
      Cuisine.DeleteAll();
    }
  }
}
