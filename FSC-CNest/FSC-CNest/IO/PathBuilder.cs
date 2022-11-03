namespace FSC_CNest.IO
{
    public class PathBuilder
    {
        private List<string> _path = new();
        private List<string> _forwardHistory = new();

        public PathBuilder()
        {

        }

        public PathBuilder(string startPath)
        {
            GoTo(startPath);
        }

        public bool CanGoForward
        {
            get
            {
                return _forwardHistory.Any();
            }
        }

        public bool CanGoBack
        {
            get
            {
                return _path.Any();
            }
        }

        public int Count
        {
            get
            {
                return _path.Count;
            }
        }

        public PathBuilder GoTo(string path)
        {
            path = path.Replace(@"\", "/");
            string[] pathElements = path.Split('/');
            
            return GoTo(pathElements);
        }

        public PathBuilder GoTo(params string[] pathElements)
        {
            List<string> path = new List<string>(pathElements);

            return GoTo(path);
        }

        public PathBuilder GoTo(List<string> pathElements)
        {
            _path.AddRange(pathElements);
            _forwardHistory.Clear();

            return this;
        }

        public PathBuilder GoForward()
        {
            if (CanGoForward)
            {
                _path.Add(_forwardHistory[_forwardHistory.Count - 1]);
                _forwardHistory.RemoveAt(_forwardHistory.Count - 1);
            }

            return this;
        }

        public PathBuilder GoBack()
        {
            if (CanGoBack)
            {
                _forwardHistory.Add(_path[_path.Count - 1]);
                _path.RemoveAt(_path.Count - 1);
            }

            return this;
        }

        public override string ToString()
        {
            return Path.Combine(_path.ToArray());
        }
    }
}
