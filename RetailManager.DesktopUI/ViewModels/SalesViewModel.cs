﻿using Caliburn.Micro;
using System.ComponentModel;

namespace RetailManager.DesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;
        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private string _itemQuantity;
        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO: Replace with calculation
                return "$0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                return output;
            }
        }

        public void AddToCart()
        {
        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;
                return output;
            }
        }

        public void RemoveFromCart()
        {
        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;
                return output;
            }
        }

        public void CheckOut()
        {
        }
    }
}