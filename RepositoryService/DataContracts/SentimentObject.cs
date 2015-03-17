
using System.Runtime.Serialization;

namespace RepositoryService.DataContracts
{
    [DataContract]
    public class SentimentObject
    {

        public SentimentObject(Data.Sentiment entity)
        {
            SentimentId = entity.SentimentId;
            PostId = entity.PostId;
            SentimentTypeId = entity.SentimentTypeId;
            Score = entity.Score;
            SentimentTypeObject = new SentimentTypeObject(entity.SentimentType);
            PostObject = new PostObject(entity.Post);
        }

        [DataMember]
        public int SentimentId { get; set; }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public int SentimentTypeId { get; set; }
        [DataMember]
        public int Score { get; set; }
        [DataMember]
        public SentimentTypeObject SentimentTypeObject { get; set; }
        [DataMember] PostObject PostObject { get; set; }
    }
}
