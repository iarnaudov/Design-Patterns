namespace _08._TemplatePattern
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }
    }
}
