namespace MisInterfaces
{
    public interface IVisualiza
    {
        void Visualiza();
    }

    public interface IFigura
    {
        void Dibujar();
        float Area();
        float Perimetro();
    }
    
    public interface IEstudios
    {
        void EdadMinima();
    }

    public enum MediaState
    {
        Playing, Stopped, Paused
    }

    public interface IMedia
    {       
        void Play();
        void Stop();
        void Pause();
        void Next();
        void Previous();
        string GetMessageToDisplay();
    }
}
