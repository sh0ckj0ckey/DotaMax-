using DotaMax.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DotaMax.ViewModels
{
    public class BBSViewModel
    {
        public ObservableCollection<Models.BBSTopic.Child1> TopicsCollection = new ObservableCollection<Models.BBSTopic.Child1>();

        public void InitAction()
        {
            GetBBSTopics();
        }

        private async void GetBBSTopics()
        {
            var topics = await ApiHelper.GetBBSTopics();
            foreach (var topic in topics.topics[1].children)
            {
                TopicsCollection.Add(topic);
            }
        }

    }
}
