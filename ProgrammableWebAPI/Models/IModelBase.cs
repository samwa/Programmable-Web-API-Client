using System;
namespace ProgrammableWebAPI.Models
{
    public interface IModelBase
    {
        string Author { get; set; }
        string CommentUrl { get; set; }
        DateTime DateModified { get; set; }
        string Description { get; set; }
        int Downloads { get; set; }
        string Icon { get; set; }
        string Id { get; set; }
        string Label { get; set; }
        string Link { get; set; }
        string Name { get; set; }
        int NumComments { get; set; }
        decimal Rating { get; set; }
        string SampleUrl { get; set; }
        string Self { get; set; }
        string Summary { get; set; }
        System.Collections.Generic.List<string> Tags { get; set; }
        string Title { get; set; }
        int Type { get; set; }
        DateTime Updated { get; set; }
        int UseCount { get; set; }
    }
}
