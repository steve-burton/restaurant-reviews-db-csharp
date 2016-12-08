using Xunit;
using System;
using System.Collections.Generic;
using Review.Objects;

namespace  Review
{
  public class RestaurantTest : IDisposable
  {
    public RestaurantTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=review_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      int result = Restaurant.GetAll().Count;

      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_Equal_ReturnsTrueIfNamesAreTheSame()
    {
      Restaurant firstRestaurant = new Restaurant("Joes Pizza", "Pizzeria", 1);
      Restaurant secondRestaurant = new Restaurant("Joes Pizza", "Pizzeria", 1);

      Assert.Equal(firstRestaurant, secondRestaurant);
    }

    [Fact]
    public void Test_Save_SavesToDatabase()
    {
      Restaurant testRestaurant = new Restaurant("Joes Pizza", "Pizzeria", 1);

      testRestaurant.Save();
      List<Restaurant> result = Restaurant.GetAll();
      List<Restaurant> testList = new List<Restaurant>{testRestaurant};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Restaurant testRestaurant = new Restaurant("Joes Pizza", "Pizzeria", 1);

      testRestaurant.Save();
      Restaurant savedRestaurant = Restaurant.GetAll()[0];

      int result = savedRestaurant.GetId();
      int testId = testRestaurant.GetId();

      Assert.Equal(testId, result);
    }
    [Fact]
    public void Test_Find_FindsRestaurantInDatabase()
    {
      Restaurant testRestaurant = new Restaurant("Joes Pizza", "Pizzeria", 1);
      testRestaurant.Save();
      Restaurant foundRestaurant = Restaurant.Find(testRestaurant.GetId());


      Assert.Equal(testRestaurant, foundRestaurant);
    }

    public void Dispose()
    {
      Restaurant.DeleteAll();
    }
  }
}
