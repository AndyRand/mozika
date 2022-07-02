using System.Collections.Generic;
using Mozika.Domain.ApiModels;

namespace Mozika.Domain.Extensions
{
    public static class ListAlbumModelExtension
    {
        public static double SumTrackPrice(this IList<TrackApiModel> tracks){
            var somme = 0.0;
            foreach(var track in tracks){
                somme+=decimal.ToDouble(track.UnitPrice);
            }
            return somme;
        }

    }
}