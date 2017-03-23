using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;

namespace LV_Filter_Objects
{
    [Activity(Label = "ListView Filter Objects", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //DECLARATIONS
        private ListView lv;
        private SearchView sv;
        private ArrayAdapter<Spacecraft> adapter;
        private readonly IList<Spacecraft> spacecrafts = new List<Spacecraft>();


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //REFERENCES
            lv = FindViewById<ListView>(Resource.Id.lv);
            sv = FindViewById<SearchView>(Resource.Id.sv);

            //POPULATE DATA
            FillData();

            //ADAPTER
            adapter = new ArrayAdapter<Spacecraft>(this, Android.Resource.Layout.SimpleListItem1, spacecrafts);
            lv.Adapter = adapter;

            //SEARCH
            sv.QueryTextChange += Sv_QueryTextChange;

            //ITEM CLICK
            lv.ItemClick += Lv_ItemClick;
        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, adapter.GetItem(e.Position).Name, ToastLength.Short).Show();
        }

        private void Sv_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            adapter.Filter.InvokeFilter(e.NewText);
        }

        private void FillData()
        {
            Spacecraft s = new Spacecraft("Voyager", "Nuclear", "Asteroid Belt");
            spacecrafts.Add(s);

            s = new Spacecraft("Casini", "Anti-Matter", "Canis Majos");
            spacecrafts.Add(s);

            s = new Spacecraft("Enterprise", "Warp Drive", "Andromeda");
            spacecrafts.Add(s);

            s = new Spacecraft("Pioneer", "Solar", "Venus");
            spacecrafts.Add(s);

            s = new Spacecraft("Rosetter", "Warp Drive", "Pluto");
            spacecrafts.Add(s);

            s = new Spacecraft("Spitzer", "Plasma Ions", "Andromeda");
            spacecrafts.Add(s);

            s = new Spacecraft("Discovery", "Plasma Ions", "Andromeda");
            spacecrafts.Add(s);

            s = new Spacecraft("Atlantis", "Plasma Ions", "Andromeda");
            spacecrafts.Add(s);

            s = new Spacecraft("Columbia", "Chemical", "Space");
            spacecrafts.Add(s);

            s = new Spacecraft("Apollo", "Chemical", "Space");
            spacecrafts.Add(s);

            s = new Spacecraft("Challenger", "Warp Drive", "Sombrero");
            spacecrafts.Add(s);

            s = new Spacecraft("Curiosity", "Solar", "Mars");
            spacecrafts.Add(s);

            s = new Spacecraft("Opportunity", "Solar", "Mars");
            spacecrafts.Add(s);

            s = new Spacecraft("Kepler", "Solar", "Jupiter");
            spacecrafts.Add(s);
        }

    }
}


