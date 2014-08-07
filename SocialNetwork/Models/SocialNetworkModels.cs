using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models
{

    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Exercise> Exercises {get; set;}  
    }
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public ApplicationUser User { get; set; }   //author
        public string Title { get; set; }
        public bool State { get; set; }  
        public string Text { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public DateTime CreationDateTime { get; set; }
       // public ICollection<ApplicationUser> ListOfSolved { get; set; }

        public ICollection<UserLikeState> Likes { get; set; }

        // Sheet solution:
        //public int Rating
        //{
        //    get
        //    {
        //        return Likes == null
        //            ? 0
        //            : Likes.Sum(x => x.Score);
        //    }
        //}

        public ICollection<Content> ListOfTheContent { get; set; }
    }

    public class UserLikeState
    {
        [Key]
        public int LikeId { get; set; }
        public ApplicationUser User { get; set; }
        public Exercise Exercise { get; set; }
        public int Score { get; set; }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
        public ICollection<ApplicationUser> ApplicationUser { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
        public string Name { get; set; }
        public bool Correctness  { get; set; }
 
    }

    public class Content            
    {
        public int ContentId { get; set; }
        public string ContentPath { get; set; }
    }

}