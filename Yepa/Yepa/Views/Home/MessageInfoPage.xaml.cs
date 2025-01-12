using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Yepa.Models;
using Yepa.Services;
using Yepa.ViewModels;
//


using System.Text;
using System.Threading.Tasks;



namespace Yepa.Views.Home{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessageInfoPage : ContentPage{
        readonly MessageModel messageModel;

        public MessageInfoPage(MessageModel _messageModel){
            InitializeComponent();
            messageModel = _messageModel;
            BindingContext = new MessageViewModels(messageModel);
        }
        
    }


}