namespace FSC_CNest.IO
{
    public class PathBuilder
    {
        private List<string> _path = new();
        private int _currentLocation = -1;

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
                return _currentLocation == _path.Count - 1;
            }
        }

        public bool CanGoBack
        {
            get
            {
                return _currentLocation > -1;
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
            if (_path.Count > 0 && _currentLocation > 0)
            {
                int index = _currentLocation + 1;
                int count = (_path.Count - 1) - index;
                _path.RemoveRange(index, count);
            }

            _path.AddRange(pathElements);

            _currentLocation = _path.Count - 1;

            return this;
        }

        public PathBuilder GoForward()
        {
            if (CanGoForward)
            {
                _currentLocation++;
            }

            return this;
        }

        public PathBuilder GoBack()
        {
            if (CanGoBack)
            {
                _currentLocation--;
            }

            return this;
        }

        public override string ToString()
        {
            var path = new List<string>();
            for (var i = 0; i <= _currentLocation; i++)
            {
                path.Add(_path[i]);
            }
            return Path.Combine(path.ToArray());
        }
    }
}
