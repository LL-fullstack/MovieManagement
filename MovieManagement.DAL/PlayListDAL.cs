using MovieManagement.Models;

namespace MovieManagement.DAL
{
    public class PlayListDAL
    {
        private readonly MovieManagementContext _context;

        public PlayListDAL (MovieManagementContext context)
        {
            _context = context;
        }

        public List<PlayList> GetPlayLists()
        {
            return _context.PlayLists.ToList();
        }

        public PlayList GetPlayList(int PlayListId)
        {
            return _context.PlayLists.Find(PlayListId);
        }

        public void AddPlayList(PlayList playList)
        {
            _context.PlayLists.Add(playList);
            _context.SaveChanges();
        }

        public void DeletePlayList(int PlayListId)
        {
            var playList = _context.PlayLists.Find(PlayListId);
            if (playList != null)
            {
                _context.PlayLists.Remove(playList);
                _context.SaveChanges();
            }
        }

        public List<MoviePlayList> GetMoviesInPlayList(int PlayListId)
        {
            return _context.MoviePlayLists.Where(mp => mp.PlayListId == PlayListId).ToList();
        }

        public void AddMoviePlayList(MoviePlayList moviePlayList)
        {
            _context.MoviePlayLists.Add(moviePlayList);
            _context.SaveChanges();
        }

        public void DeleteMoviePlayList(int PlayListId, int MovieId)
        {
            var moviePlayList = _context.MoviePlayLists.FirstOrDefault(mp => mp.PlayListId == PlayListId && mp.MovieId == MovieId);
            if (moviePlayList != null)
            {
                _context.MoviePlayLists.Remove(moviePlayList);
                _context.SaveChanges();
            }
        }
    }
}
