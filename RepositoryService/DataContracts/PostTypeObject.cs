
using System.Runtime.Serialization;

namespace RepositoryService.DataContracts
{
    using System.Collections.Generic;
    
    [DataContract]
    public class PostTypeObject
    {
  
        public PostTypeObject()
        {
            Posts = new HashSet<PostObject>();
        }

        public PostTypeObject(Data.PostType entity)
        {
            PostTypeId = entity.PostTypeId;
            Name = entity.Name;
            Posts = PopulatePosts(entity);
        }

        private ICollection<PostObject> PopulatePosts(Data.PostType entity)
        {
            var posts = new HashSet<PostObject>();
            foreach (var post in entity.Posts)
            {
                posts.Add(new PostObject(post));
            }
            return posts;
        }


        [DataMember]
        public int PostTypeId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public ICollection<PostObject> Posts { get; set; }
    }
}
