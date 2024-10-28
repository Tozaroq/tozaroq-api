
namespace Tozaroq.Infrastructure.Enums.Posts
{
    public enum PostStatus
    {
        /// <summary>
        /// The post is in draft mode and not visible to others.
        /// </summary>
        Draft,

        /// <summary>
        /// The post is live and available for performers to view and pick up.
        /// </summary>
        Available,

        /// <summary>
        /// A performer has been assigned to the post.
        /// </summary>
        Attached,

        /// <summary>
        /// The assigned performer is currently working on the task.
        /// </summary>
        InProgress,

        /// <summary>
        /// The performer believes the task is done, but the author has requested changes.
        /// </summary>
        RevisionRequired,

        /// <summary>
        /// The task is completed and awaiting approval from the author.
        /// </summary>
        AwaitingApproval,

        /// <summary>
        /// The task has been completed and verified as done.
        /// </summary>
        Done
    }
}
