using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Web.ViewModels
{
    public class CompositeViewModel
    {
        public IEnumerable<CollectionCardViewModel>? PlayLists { get; set; }
        public IEnumerable<SongCardViewModel>? Songs { get; set; }
    }
}
