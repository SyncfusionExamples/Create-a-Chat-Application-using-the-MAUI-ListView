using System.Collections.ObjectModel;

namespace ChatApplication
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Message
    {
        public string? Name { get; set; }
        public string? Text { get; set; }
        public bool IsIncoming { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Message> Messages { get; set; }

        public ViewModel()
        {
            Messages = new ObservableCollection<Message>
            {
                new Message { Name = "You", Text = "Hi everyone! I'm very excited to share the news that our team is launching a new mobile application.", IsIncoming = false, ProfilePicture = "andrea.png", Timestamp = DateTime.Now.AddMinutes(-2)},
                new Message { Name = "Harrison", Text = "Oh, that's great!", IsIncoming = true, ProfilePicture = "harrison.png", Timestamp = DateTime.Now.AddMinutes(-1)},
                new Message { Name = "Margaret", Text = "That is a good news.", IsIncoming = true, ProfilePicture = "margaret.png", Timestamp = DateTime.Now.AddMinutes(2)},
                new Message { Name = "Nancy", Text = "Are we going to develop the app natively or as a hybrid?", IsIncoming = true, ProfilePicture = "nancy.png", Timestamp = DateTime.Now.AddMinutes(3)},
                new Message { Name = "You", Text = "We should develop this app using .NET MAUI, as it offers a native experience and performance while allowing for seamless cross-platform development.", IsIncoming = false, ProfilePicture = "andrea.png", Timestamp = DateTime.Now.AddMinutes(5)},
                new Message { Name = "Steven", Text = "I haven't heard of .NET MAUI. What's .NET MAUI?", IsIncoming = true, ProfilePicture = "steven.png", Timestamp = DateTime.Now.AddMinutes(7)},
                new Message { Name = "You", Text = ".NET MAUI is a new library that allows you to build native user interfaces for Android, iOS, macOS, and Windows from a single shared C# codebase.", IsIncoming = false, ProfilePicture = "andrea.png", Timestamp = DateTime.Now.AddMinutes(9)},
                new Message { Name = "David", Text = "That's impressive.", IsIncoming = true, ProfilePicture = "david.png", Timestamp = DateTime.Now.AddMinutes(10)},
            };
        }
    }

    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? IncomingDataTemplate { get; set; }
        public DataTemplate? OutgoingDataTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Message message)
            {
                return message.IsIncoming ? IncomingDataTemplate : OutgoingDataTemplate;
            }

            return null;
        }
    }
}
