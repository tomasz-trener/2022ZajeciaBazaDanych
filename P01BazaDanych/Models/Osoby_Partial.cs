using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01BazaDanych.Models
{
    public partial class Osoby
    {
        public string DaneDoWyswietlenia =>
            $"{Imie} {Nazwisko} {Wzrost} {DataUr?.ToString("dd-MM-yyyy")}";
    }
}