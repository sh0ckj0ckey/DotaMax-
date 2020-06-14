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

        /// <summary>
        /// 获取话题
        /// </summary>
        private async void GetBBSTopics()
        {
            if (TopicsCollection.Count <= 0)
            {
                var topics = await MaxApi.GetBBSTopics();
                if (topics == null)
                {
                    // 没有获取到话题
                    return;
                }
                foreach (var topic in topics.topics[1].children)
                {
                    TopicsCollection.Add(topic);
                }
            }
        }

    }
}
