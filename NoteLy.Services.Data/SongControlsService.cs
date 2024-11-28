using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Services.Data
{
    public class SongControlsService : ISongControlsService
    {
        private IRepository<Song, int> songRepository;

        public SongControlsService(IRepository<Song, int> songRepository)
        {
            this.songRepository = songRepository;
        }

        public Song? GetSong(int id)
        {
            Song? song = this.songRepository.GetById(id);
            return song;
        }
    }
}
