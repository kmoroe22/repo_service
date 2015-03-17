
using System.Runtime.Serialization;

namespace RepositoryService.DataContracts
{
    [DataContract]
    public class PostObject
    {


        public PostObject(Data.Post entity)
        {
            PostId = entity.PostId;
            PostTypeId = entity.PostType;
            PostTypeObject = new PostTypeObject(entity.PostType1);
        }

        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public int PostTypeId { get; set; }
        [DataMember]
        public PostTypeObject PostTypeObject { get; set; }
    }
}
