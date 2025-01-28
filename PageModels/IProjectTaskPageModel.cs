using CommunityToolkit.Mvvm.Input;
using MauiAppCrashTest.Models;

namespace MauiAppCrashTest.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}