namespace lab_work_uni_csharp;

class IdGenerator
{
    public long Id => _id == long.MaxValue ? 0 : ++_id;

    public IdGenerator Clear()
    {
        if (this != null)
        {
            _id = 0;
        }
        return this;
    }

    private long _id;
}