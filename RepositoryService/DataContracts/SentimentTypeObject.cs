
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RepositoryService.DataContracts
{
    [DataContract]
    public class SentimentTypeObject
    {
        public SentimentTypeObject()
        {
            Sentiments = new HashSet<SentimentObject>();
        }

        public SentimentTypeObject(Data.SentimentType entity)
        {
            SentimentTypeId = entity.SentimentTypeId;
            Name = entity.Name;
            MaxScore = entity.MaxScore;
            Sentiments = PopulateSenitments(entity);
        }

        [DataMember]
        public int SentimentTypeId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int MaxScore { get; set; }
        [DataMember]
        public ICollection<SentimentObject> Sentiments { get; set; }

        private ICollection<SentimentObject> PopulateSenitments(Data.SentimentType entity)
        {
            var sentiments = new HashSet<SentimentObject>();
            foreach (var sentiment in entity.Sentiments)
            {
                sentiments.Add(new SentimentObject(sentiment));
            }
            return sentiments;
        }
    }
}
