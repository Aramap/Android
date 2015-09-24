 using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CustomLists
{
	[Activity (Label = "CustomLists", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		ListView listView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			listView = FindViewById<ListView> (Resource.Id.Lists);

			List<Data> myList = new List<Data> ();

			Data obj = new Data ();
			obj.Heading = "Apple";
			obj.SubHeading = "An Apple a day keeps the doctor away";
			obj.ImageURI = "http://cdn-www.i-am-bored.com/media/thumbnails/apple_for-diabetics[1].jpg";

			myList.Add (obj);

			Data obj1 = new Data ();
			obj1.Heading = "Banana";
			obj1.SubHeading = "Bananas are an excellent source of vitamin B6";
			obj1.ImageURI = "http://www.bbcgoodfood.com/sites/bbcgoodfood.com/files/glossary/banana-crop.jpg";

			myList.Add (obj1);

			Data obj2 = new Data ();
			obj2.Heading = "Kiwi Fruit";
			obj2.SubHeading = "Kiwifruit is a rich source of vitamin C";
			obj2.ImageURI = "http://www.wiffens.com/wp-content/uploads/kiwi.png";

			myList.Add (obj2);

			Data obj3 = new Data ();
			obj3.Heading = "Pineapple";
			obj3.SubHeading = "Raw Pineapple is an excellent source of manganese";
			obj3.ImageURI = "http://www.medicalnewstoday.com/images/articles/276/276903/pineapple.jpg";

			myList.Add (obj3);

			Data obj4 = new Data ();
			obj4.Heading = "This is ninth Line";
			obj4.SubHeading = "One serving (100g) of strawberries contains approximately 33 kilocalories";
			obj4.ImageURI = "https://flavorrun.files.wordpress.com/2015/03/strawberry1.jpg";

			myList.Add (obj4);

			listView.Adapter = new DataAdapter (this, myList);
		}
	}
}


