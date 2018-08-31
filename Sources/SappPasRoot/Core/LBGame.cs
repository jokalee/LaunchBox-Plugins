﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbroken.LaunchBox.Plugins.Data;

namespace SappPasRoot.Core
{
    class LBGame : IGame
    {
        public Image RatingImage { get; set; }

        public string ScreenshotImagePath { get; set; }

        public string FrontImagePath { get; set; }

        public string MarqueeImagePath { get; set; }

        public string BackImagePath { get; set; }

        public string Box3DImagePath { get; set; }

        public string BackgroundImagePath { get; set; }

        public string Cart3DImagePath { get; set; }

        public string CartFrontImagePath { get; set; }

        public string CartBackImagePath { get; set; }

        public string ClearLogoImagePath { get; set; }

        public string DetailsWithPlatform { get; set; }

        public string DetailsWithoutPlatform { get; set; }

        public string PlatformClearLogoImagePath { get; set; }

        public string ApplicationPath { get; set; }
        public string CommandLine { get; set; }
        public bool Completed { get; set; }
        public string ConfigurationCommandLine { get; set; }
        public string ConfigurationPath { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Developer { get; set; }
        public string DosBoxConfigurationPath { get; set; }
        public string EmulatorId { get; set; }
        public bool Favorite { get; set; }

        public string Id;

        public DateTime? LastPlayedDate { get; set; }
        public string ManualPath { get; set; }
        public string MusicPath { get; set; }
        public string Notes { get; set; }
        public string Platform { get; set; }
        public string Publisher { get; set; }
        public string Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleaseYear { get; set; }
        public string RootFolder { get; set; }
        public bool ScummVmAspectCorrection { get; set; }
        public bool ScummVmFullscreen { get; set; }
        public string ScummVmGameDataFolderPath { get; set; }
        public string ScummVmGameType { get; set; }
        public bool ShowBack { get; set; }
        public string SortTitle { get; set; }
        public string Source { get; set; }
        public int StarRating { get; set; }

        public float CommunityOrLocalStarRating;

        public float StarRatingFloat { get; set; }
        public float CommunityStarRating { get; set; }
        public int CommunityStarRatingTotalVotes { get; set; }
        public string Status { get; set; }
        public int? LaunchBoxDbId { get; set; }
        public int? WikipediaId { get; set; }
        public string WikipediaUrl { get; set; }
        public string Title { get; set; }
        public bool UseDosBox { get; set; }
        public bool UseScummVm { get; set; }
        public string Version { get; set; }
        public string Series { get; set; }
        public string PlayMode { get; set; }
        public string Region { get; set; }
        public int PlayCount { get; set; }
        public bool Portable { get; set; }
        public string VideoPath { get; set; }
        public string ThemeVideoPath { get; set; }
        public bool Hide { get; set; }
        public bool Broken { get; set; }
        public string CloneOf { get; set; }
        public string GenresString { get; set; }

        string IGame.Id { get;  }

        float IGame.CommunityOrLocalStarRating { get; }

        BlockingCollection<string> IGame.Genres { get;  }

        string[] IGame.PlayModes { get; }

        string[] IGame.Developers { get;}

        string[] IGame.Publishers { get;  }

        string[] IGame.SeriesValues { get;  }

        string IGame.SortTitleOrTitle { get;  }

        public BlockingCollection<string> Genres;

        public string[] PlayModes;

        public string[] Developers;

        public string[] Publishers;

        public string[] SeriesValues;

        public string SortTitleOrTitle;

        public IAdditionalApplication AddNewAdditionalApplication()
        {
            throw new NotImplementedException();
        }

        public ICustomField AddNewCustomField()
        {
            throw new NotImplementedException();
        }

        public IMount AddNewMount()
        {
            throw new NotImplementedException();
        }

        public string Configure()
        {
            throw new NotImplementedException();
        }

        public IAdditionalApplication[] GetAllAdditionalApplications()
        {
            throw new NotImplementedException();
        }

        public ICustomField[] GetAllCustomFields()
        {
            throw new NotImplementedException();
        }

        public ImageDetails[] GetAllImagesWithDetails()
        {
            throw new NotImplementedException();
        }

        public ImageDetails[] GetAllImagesWithDetails(string imageType)
        {
            throw new NotImplementedException();
        }

        public IMount[] GetAllMounts()
        {
            throw new NotImplementedException();
        }

        public string GetBigBoxDetails(bool showPlatform)
        {
            throw new NotImplementedException();
        }

        public string GetManualPath()
        {
            throw new NotImplementedException();
        }

        public string GetMusicPath()
        {
            throw new NotImplementedException();
        }

        public string GetNewManualFilePath(string extension)
        {
            throw new NotImplementedException();
        }

        public string GetNewMusicFilePath(string extension)
        {
            throw new NotImplementedException();
        }

        public string GetNewThemeVideoFilePath(string extension)
        {
            throw new NotImplementedException();
        }

        public string GetNewVideoFilePath(string extension)
        {
            throw new NotImplementedException();
        }

        public string GetNextAvailableImageFilePath(string extension, string imageType, string region)
        {
            throw new NotImplementedException();
        }

        public string GetThemeVideoPath()
        {
            throw new NotImplementedException();
        }

        public string GetVideoPath(bool prioritizeThemeVideos = false)
        {
            throw new NotImplementedException();
        }

        public string OpenFolder()
        {
            throw new NotImplementedException();
        }

        public string OpenManual()
        {
            throw new NotImplementedException();
        }

        public string Play()
        {
            throw new NotImplementedException();
        }

        public bool TryRemoveAdditionalApplication(IAdditionalApplication additionalApplication)
        {
            throw new NotImplementedException();
        }

        public bool TryRemoveCustomField(ICustomField customField)
        {
            throw new NotImplementedException();
        }

        public bool TryRemoveMount(IMount mount)
        {
            throw new NotImplementedException();
        }
    }
}
