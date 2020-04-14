﻿namespace Movys.Web.ViewModels.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListingFavoriteMoviesViewModel
    {
        public IEnumerable<FavoriteMovieViewModel> Movies { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

        public int MoviesCount { get; set; }
    }
}
