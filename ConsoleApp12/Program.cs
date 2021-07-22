using System.Collections.Generic;
using System;
using ConsoleApp11.Models;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var artistcontext = new ArtistContext())
            {
                List<Albums> albums = new List<Albums>()
                {   
                    new Albums() { AlbumId = 1, AlbumTitle = "200 Po Vstrechnoy", ArtistId = 1}
                };

                List<AlbumsSongs> albumsSongs = new List<AlbumsSongs>()
                {
                    new AlbumsSongs() { AlbumId = 1, SondId = 1, TrackNumber = 1 }
                };

                List<Artists> artists = new List<Artists>()
                {
                    new Artists() { ArtistId = 1, CountryId = 1, GenreId = 1 }
                };

                List<Countries> countries = new List<Countries>()
                {
                    new Countries() { CountryId = 1, CountryName = "Russia" }
                };

                List<Genres> genres = new List<Genres>()
                {
                    new Genres() { GenreId = 1, GenreName = "Pop music" }
                };

                List<Groups> groups = new List<Groups>()
                {
                    new Groups() { ArtistId = 1, GroupName = "Tatu" }
                };

                List<Persons> persons = new List<Persons>()
                {
                    new Persons() { ArtistId = 1, FirstName = "Julia", LastName = "Volkova", Sex = "Woman" }
                };

                List<Songs> songs = new List<Songs>()
                {
                    new Songs() { SongId = 1, SongTitle = "All the things she said" }
                };

                artistcontext.SaveChanges();
            }
        }
    }
}
