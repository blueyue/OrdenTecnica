﻿using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using appOrdenTecnica.Fragments; // Traemos a los Fragmentos


namespace appOrdenTecnica
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {

        Fragments_lista_ordenes frgListOrdenes;
        Fragments_nueva_orden nueva_orden;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            // Instanciamos el objeto
            frgListOrdenes = new Fragments_lista_ordenes();
            // Asignamos variable a Fragment Manager e iniciamos la transaccion
            var transaccion = SupportFragmentManager.BeginTransaction();
            // Le asignamos el contenedor de los fragmentos y el fragmento que cargara
            transaccion.Add(Resource.Id.ConteinerLayout, frgListOrdenes);
            // Confirmamos la transaccion
            transaccion.Commit();
            

        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nuev_orden)
            {
                // Handle the camera action
                nueva_orden = new Fragments_nueva_orden();
                var transaccion = SupportFragmentManager.BeginTransaction();
                // Reemplazamos el contenido anterior con el nuevo fragmento
                transaccion.Replace(Resource.Id.ConteinerLayout, nueva_orden);
                // Confirmamos la transaccion
                transaccion.Commit();
            }
            else if (id == Resource.Id.reg_ord)
            {
                // Instanciamos el objeto
                frgListOrdenes = new Fragments_lista_ordenes();
                // Asignamos variable a Fragment Manager e iniciamos la transaccion
                var transaccion = SupportFragmentManager.BeginTransaction();
                // Le asignamos el contenedor de los fragmentos y el fragmento que cargara
                transaccion.Replace(Resource.Id.ConteinerLayout, frgListOrdenes);
                // Confirmamos la transaccion
                transaccion.Commit();
            }
            else if (id == Resource.Id.asig_tecn)
            {
                // Instanciamos el objeto
                frgListOrdenes = new Fragments_lista_ordenes();
                // Asignamos variable a Fragment Manager e iniciamos la transaccion
                var transaccion = SupportFragmentManager.BeginTransaction();
                // Le asignamos el contenedor de los fragmentos y el fragmento que cargara
                transaccion.Replace(Resource.Id.ConteinerLayout, frgListOrdenes);
                // Confirmamos la transaccion
                transaccion.Commit();
            }
            else if (id == Resource.Id.ord_pend)
            {
                // Instanciamos el objeto
                frgListOrdenes = new Fragments_lista_ordenes();
                // Asignamos variable a Fragment Manager e iniciamos la transaccion
                var transaccion = SupportFragmentManager.BeginTransaction();
                // Le asignamos el contenedor de los fragmentos y el fragmento que cargara
                transaccion.Replace(Resource.Id.ConteinerLayout, frgListOrdenes);
                // Confirmamos la transaccion
                transaccion.Commit();
            }
            else if (id == Resource.Id.cerr_ses)
            {

            }
           

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

