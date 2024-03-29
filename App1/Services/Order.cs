﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.Services
{
	/// <summary>
	/// 
	/// </summary>
	public class Order : INotifyPropertyChanged
	{
		#region Private Members

		private int _quantity;
		private int rate;

		#endregion

		#region Public Members

		/// <summary>
		/// 
		/// </summary>
		public Order()
		{
				
		}

		/// <summary>
		/// 
		/// </summary>
		public string ProductName { get; set; }

		public int Quantity
		{
			get { return _quantity; }
			set
			{
				if (value != _quantity)
				{
					_quantity = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity"));
				}
			}
		}

		public int Rating
		{
			get { return rate; }
			set
			{
				rate = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rating"));
			}
		}

		#region INotifyPropertyChanged Interface

		/// <summary>
		/// 
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
		
		#endregion
		
		#endregion
	}
}
