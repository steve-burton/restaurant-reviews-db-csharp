using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Review.Objects
{
	public class Restaurant
	{
		private int _id;
		private string _name;
		private string _description;
		private int _cuisineId;

		public Restaurant(string restaurantName, string restaurantDescription, int restaurantCuisineId, int Id = 0)
		{
			_name = restaurantName;
			_description = restaurantDescription;
			_cuisineId = restaurantCuisineId;
			_id = Id;
		}

		public override bool Equals(System.Object otherRestaurant)
		{
			if (!(otherRestaurant is Restaurant))
			{
				return false;
			}
			else
			{
				Restaurant newRestaurant = (Restaurant) otherRestaurant;
				bool idEquality = (this.GetId() == newRestaurant.GetId());
				bool nameEquality = (this.GetName() == newRestaurant.GetName());
				bool descriptionEquality = (this.GetDescription() == newRestaurant.GetDescription());
				bool cuisineIdEquality = (this.GetCuisineId() == newRestaurant.GetCuisineId());
				return (idEquality && nameEquality && descriptionEquality && cuisineIdEquality);
			}
		}


		public int GetId()
		{
			return _id;
		}
		public string GetName()
		{
			return _name;
		}
		public string GetDescription()
		{
			return _description;
		}
		public int GetCuisineId()
		{
			return _cuisineId;
		}
		public void SetId(int Id)
		{
			_id = Id;
		}
		public void SetName(string restaurantName)
		{
			_name = restaurantName;
		}
		public void SetDescription(string restaurantDescription)
		{
			_description = restaurantDescription;
		}
		public void SetCuisineId(int restaurantCuisineId)
		{
			_cuisineId = restaurantCuisineId;
		}

		public static List<Restaurant> GetAll()
		{
			List<Restaurant> allRestaurants = new List<Restaurant>{};

			SqlConnection conn = DB.Connection();
			conn.Open();

			SqlCommand cmd = new SqlCommand("SELECT * FROM restaurant;", conn);
			SqlDataReader rdr = cmd.ExecuteReader();

			while(rdr.Read())
			{
				string restaurantName = rdr.GetString(0);
				string restaurantDescription = rdr.GetString(1);
				int restaurantCuisineId = rdr.GetInt32(2);
				int restaurantId = rdr.GetInt32(3);
				Restaurant newRestaurant = new Restaurant(restaurantName, restaurantDescription, restaurantCuisineId, restaurantId);
				allRestaurants.Add(newRestaurant);
			}
			if(rdr != null)
			{
				rdr.Close();
			}
			if(conn != null)
			{
				conn.Close();
			}
			return allRestaurants;
		}

		public void Save()
		{
			SqlConnection conn = DB.Connection();
			conn.Open();

			SqlCommand cmd = new SqlCommand("INSERT INTO restaurant (name, description, cuisine_id) OUTPUT INSERTED.id VALUES (@RestaurantName, @restaurantDescription, @restaurantCuisineId);", conn);

			SqlParameter nameParameter = new SqlParameter();
			nameParameter.ParameterName = "@RestaurantName";
			nameParameter.Value = this.GetName();

			SqlParameter descriptionParameter = new SqlParameter();
			descriptionParameter.ParameterName = "@RestaurantDescription";
			descriptionParameter.Value = this.GetDescription();

			SqlParameter cuisineIdParameter = new SqlParameter();
			cuisineIdParameter.ParameterName = "@restaurantCuisineId";
			cuisineIdParameter.Value = this.GetCuisineId();

			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(cuisineIdParameter);

			SqlDataReader rdr = cmd.ExecuteReader();

			while(rdr.Read())
			{
				this._id = rdr.GetInt32(0);
			}
			if (rdr != null)
			{
				rdr.Close();
			}
			if (conn != null)
			{
				conn.Close();
			}
		}

		public static void DeleteAll()
		{
			SqlConnection conn = DB.Connection();
			conn.Open();
			SqlCommand cmd = new SqlCommand("DELETE FROM restaurant;", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
	}
}
