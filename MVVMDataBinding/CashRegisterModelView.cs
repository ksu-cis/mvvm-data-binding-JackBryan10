using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    public class CashRegisterModelView: INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Gets and sets the amount of Pennies in the drawer
        /// </summary>
        public int Pennies 
        {
            get => drawer.Pennies;
            set 
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if(quantity > 0) { drawer.AddCoin(Coins.Penny, quantity); }
                else { drawer.RemoveCoin(Coins.Penny, -quantity); }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Nickels in the drawer
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0) { drawer.AddCoin(Coins.Nickel, quantity); }
                else { drawer.RemoveCoin(Coins.Nickel, -quantity); }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Dimes in the drawer
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0) { drawer.AddCoin(Coins.Dime, quantity); }
                else { drawer.RemoveCoin(Coins.Dime, -quantity); }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Quarters in the drawer
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0) { drawer.AddCoin(Coins.Quarter, quantity); }
                else { drawer.RemoveCoin(Coins.Quarter, -quantity); }
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets and sets the amount of HalfDollars in the drawer
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0) { drawer.AddCoin(Coins.HalfDollar, quantity); }
                else { drawer.RemoveCoin(Coins.HalfDollar, -quantity); }
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets and sets the amount of HalfDollars in the drawer
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0) { drawer.AddCoin(Coins.Dollar, quantity); }
                else { drawer.RemoveCoin(Coins.Dollar, -quantity); }
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Ones in the drawer
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0) { drawer.AddBill(Bills.One, quantity); }
                else { drawer.RemoveBill(Bills.One, -quantity); }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Twos in the drawer
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0) { drawer.AddBill(Bills.Two, quantity); }
                else { drawer.RemoveBill(Bills.Two, -quantity); }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Fives in the drawer
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0) { drawer.AddBill(Bills.Five, quantity); }
                else { drawer.RemoveBill(Bills.Five, -quantity); }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Tens in the drawer
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0) { drawer.AddBill(Bills.Ten, quantity); }
                else { drawer.RemoveBill(Bills.Ten, -quantity); }
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Twenties in the drawer
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0) { drawer.AddBill(Bills.Twenty, quantity); }
                else { drawer.RemoveBill(Bills.Twenty, -quantity); }
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Fifties in the drawer
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0) { drawer.AddBill(Bills.Fifty, quantity); }
                else { drawer.RemoveBill(Bills.Fifty, -quantity); }
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Hundreds in the drawer
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0) { drawer.AddBill(Bills.Hundred, quantity); }
                else { drawer.RemoveBill(Bills.Hundred, -quantity); }
                InvokePropertyChanged("Hundreds");
            }
        }

        void InvokePropertyChanged(string denomination) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
