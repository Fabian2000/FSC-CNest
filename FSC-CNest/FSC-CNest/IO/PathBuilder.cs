namespace FSC_CNest.IO
{
    /// <summary>
    /// A path builder to build paths, go forward and backwards
    /// </summary>
    public class PathBuilder
    {
        private List<string> _path = new();
        private List<string> _forwardHistory = new();

        /// <summary>
        /// A path builder to build paths, go forward and backwards
        /// </summary>
        public PathBuilder()
        {

        }

        /// <summary>
        /// A path builder to build paths, go forward and backwards
        /// </summary>
        /// <param name="startPath">The same as the GoTo method. Goes to the given pfad</param>
        public PathBuilder(string startPath)
        {
            GoTo(startPath);
        }

        /// <summary>
        /// Returns true, if a step forward is possible
        /// </summary>
        public bool CanGoForward
        {
            get
            {
                return _forwardHistory.Any();
            }
        }

        /// <summary>
        /// Returns true, if a step backwards is possible
        /// </summary>
        public bool CanGoBack
        {
            get
            {
                return _path.Any();
            }
        }

        /// <summary>
        /// Returns the added path elements without the forward history included
        /// </summary>
        public int Count
        {
            get
            {
                return _path.Count;
            }
        }

        /// <summary>
        /// Goes to the given pfad
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public PathBuilder GoTo(string path)
        {
            path = path.Replace(@"\", "/");
            string[] pathElements = path.Split('/');
            
            return GoTo(pathElements);
        }

        /// <summary>
        /// Goes to the given pfad
        /// </summary>
        /// <param name="pathElements"></param>
        /// <returns></returns>
        public PathBuilder GoTo(params string[] pathElements)
        {
            List<string> path = new List<string>(pathElements);

            return GoTo(path);
        }

        /// <summary>
        /// Goes to the given pfad
        /// </summary>
        /// <param name="pathElements"></param>
        /// <returns></returns>
        public PathBuilder GoTo(List<string> pathElements)
        {
            _path.AddRange(pathElements);
            _forwardHistory.Clear();

            return this;
        }

        /// <summary>
        /// Goes a step forward
        /// </summary>
        /// <returns></returns>
        public PathBuilder GoForward()
        {
            if (CanGoForward)
            {
                _path.Add(_forwardHistory[_forwardHistory.Count - 1]);
                _forwardHistory.RemoveAt(_forwardHistory.Count - 1);
            }

            return this;
        }

        /// <summary>
        /// Goes a step backwards
        /// </summary>
        /// <returns></returns>
        public PathBuilder GoBack()
        {
            if (CanGoBack)
            {
                _forwardHistory.Add(_path[_path.Count - 1]);
                _path.RemoveAt(_path.Count - 1);
            }

            return this;
        }

        /// <summary>
        /// Returns the path as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Path.Combine(_path.ToArray());
        }
    }
}
