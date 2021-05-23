using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoGamesX.Models;
using ProyectoGamesX.Data;
using Rg.Plugins.Popup.Services;
using ProyectoGamesX.Views;

namespace ProyectoGamesX.ViewModels
{
    class VideojuegosViewModel:BaseViewModel
    {

      

        #region Attributes
        public string Titulo;
        public byte [] ImagenVJ;
        public string Sinopsis;
        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Properties
        public string TituloTxt
        {
            get { return this.Titulo; }
            set { SetValue(ref this.Titulo, value); }
        }

        public string SinopsisTxt
        {
            get { return this.Sinopsis; }
            set { SetValue(ref this.Sinopsis, value); }
        }

        public byte [] ImagenVJp
        {
            get { return this.ImagenVJ; }
            set { SetValue(ref this.ImagenVJ, value); }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public object ListViewSource
        {

            get { return this.listViewSource; }
            set
            {
                SetValue(ref this.listViewSource, value);
            }
        }
        #endregion

        #region Commands
        public ICommand InsertCommand
        {
            get
            {
                return new RelayCommand(InsertMethod);
            }
        }

       
        #endregion

        #region Methods
        private async void InsertMethod()
        {
            var juego = new Videojuegos
            {
                Titulos = Titulo,
                Sinopsiss = Sinopsis,
            };

            

            this.IsRefreshing = true;

            await Task.Delay(1000);

           

            this.IsRefreshing = false;
        }

       

        #endregion

        #region .



        #endregion
        #region Constructor

        #endregion
    }
}

