
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RepositoryService.DataContracts
{

    [DataContract]
    public class UserObject
    {
        public UserObject()
        {
            Posts = new HashSet<PostObject>();
        }

        public UserObject(Data.User entity)
        {
            UserId = entity.UserId;
            Name = entity.Name;
            Email = entity.Email;
            Posts = PopulatePosts(entity);
        }

        private ICollection<PostObject> PopulatePosts(Data.User entity)
        {
            var posts = new HashSet<PostObject>();
            foreach (var post in entity.Posts)
            {
                posts.Add(new PostObject(post));
            }
            return posts;
        }

        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public ICollection<PostObject> Posts { get; set; }
    }
}
