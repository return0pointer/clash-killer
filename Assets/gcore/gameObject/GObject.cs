namespace gcore.gameObject
{
    public class GObject
    {
        private string _name;
        private int _id;
        private VObject _viewObject;
        private DObject _dataObject;
        
        public GObject() {}

        public virtual void destroy() {}
        public virtual void spawn() {}
        public virtual void init() {}
        
        public DObject getData() => _dataObject;
        public VObject getView() => _viewObject;


    }
}