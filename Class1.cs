using System;

// Абстрактный класс для кинофильма
abstract class Movie
{
    public abstract string Title { get; }
    public abstract string SoundtrackLanguage { get; }
    public abstract string SubtitleLanguage { get; }
    public abstract string Play();
}

// Абстрактная фабрика для создания кинофильмов
abstract class MovieFactory
{
    public abstract Movie CreateMovie();
}

// Конкретный класс кинофильма
class ConcreteMovie : Movie
{
    private string _title;
    private string _soundtrackLanguage;
    private string _subtitleLanguage;

    public ConcreteMovie(string title, string soundtrackLanguage, string subtitleLanguage)
    {
        _title = title;
        _soundtrackLanguage = soundtrackLanguage;
        _subtitleLanguage = subtitleLanguage;
    }

    public override string Title => _title;
    public override string SoundtrackLanguage => _soundtrackLanguage;
    public override string SubtitleLanguage => _subtitleLanguage;

    public override string Play()
    {
        string info = $"Now playing: {_title}\r\n";
        info += $"Soundtrack Language: {_soundtrackLanguage}\r\n";
        info += $"Subtitle Language: {_subtitleLanguage}\r\n";
        return info;
    }




}

// Конкретная фабрика для создания кинофильмов с русскими характеристиками
class RussianMovieFactory : MovieFactory
{
    public override Movie CreateMovie()
    {
        return new ConcreteMovie("Russian Movie", "Russian", "Russian");
    }
}

// Конкретная фабрика для создания кинофильмов с английскими характеристиками
class EnglishMovieFactory : MovieFactory
{
    public override Movie CreateMovie()
    {
        return new ConcreteMovie("English Movie", "English", "English");
    }
}
class FrenchMovieFactory : MovieFactory
{
    public override Movie CreateMovie()
    {
        return new ConcreteMovie("French Movie", "French", "French");
    }
}