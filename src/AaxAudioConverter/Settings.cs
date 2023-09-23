using audiamus.aaxconv.lib;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;
using static audiamus.aux.ApplEnv;

namespace audiamus.aaxconv {

  interface IAppSettings : lib.IConvSettings, aux.win.ILanguageSetting {
    bool? FileAssoc { get; set; }
    bool? ShowStartupTip { get; set; }
    bool FileDateColumn { get; set; }
    int SettingsTab { get; set; }
  
    void Save ();
    void FixNarrator ();
  }

  interface IAppSettingsOnlineUpdateEx {
    string OnlineUpdateUrl { get; }
    bool OnlineUpdateDebug { get; }
  }

  namespace Properties {
        partial class Settings : IAppSettings, IAppSettingsOnlineUpdateEx
        {
            private static string SPEC_PATH;

            private static string GEN_PATH;

            static Settings()
            {
                SPEC_PATH = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
                SPEC_PATH = Path.Combine(Path.GetFileName(SPEC_PATH), "appsettings.json");
                string dir = LocalCompanyDirectory;
                dir = Path.Combine(dir, "_nohash", ApplName);
                var path = Path.Combine(dir, Path.GetFileName(SPEC_PATH));
                GEN_PATH = path;
            }

            private static Settings defaultInstance = new Settings();

            [Newtonsoft.Json.JsonIgnore]
            public static Settings Default
            {
                get
                {
                    return defaultInstance;
                }
            }

            public bool NonParallel { get; set; }

            public int FFmpeg64bitHours { get; set; }

            public string InputDirectory { get; set; }

            public string OutputDirectory { get; set; }

            public string FFMpegDirectory { get; set; }

            public bool RelaxedFFmpegVersionCheck { get; set; }

            public bool FileDateColumn { get; set; }

            public global::audiamus.aaxconv.lib.EConvFormat ConvFormat { get; set; } = lib.EConvFormat.mp3;

            public global::audiamus.aaxconv.lib.EConvMode ConvMode { get; set; } = lib.EConvMode.chapters;

            public byte TrkDurMins { get; set; } = 5;

            public global::audiamus.aaxconv.lib.EFileNaming FileNaming { get; set; } = lib.EFileNaming.track_book_author;

            public global::audiamus.aaxconv.lib.ETitleNaming TitleNaming { get; set; } = lib.ETitleNaming.track_book;

            public global::audiamus.aaxconv.lib.ETrackNumbering TrackNumbering { get; set; } = lib.ETrackNumbering.track;

            public bool TotalTracks { get; set; } = false;

            public global::System.Nullable<System.Boolean> Narrator { get; set; }

            public global::audiamus.aaxconv.lib.EGeneralNaming GenreNaming { get; set; } = lib.EGeneralNaming.standard;

            public string GenreName { get; set; }

            public global::audiamus.aaxconv.lib.EGeneralNamingEx ChapterNaming { get; set; } = lib.EGeneralNamingEx.standard;

            public string ChapterName { get; set; }

            public bool SeriesTitleLeft { get; set; } = false;

            public global::audiamus.aaxconv.lib.ELongTitle LongBookTitle { get; set; } = lib.ELongTitle.no;

            public global::audiamus.aaxconv.lib.EGeneralNaming PartNaming { get; set; } = lib.EGeneralNaming.standard;

            public string PartName { get; set; }

            public global::System.Nullable<System.Boolean> FileAssoc { get; set; }

            public global::System.Nullable<System.UInt32> ActivationCode { get; set; }

            public string Language { get; set; }

            public string PartNames { get; set; }

            public string AddnlValTitlePunct { get; set; }

            public string Genres { get; set; }

            public bool FlatFolders { get; set; }

            public global::audiamus.aaxconv.lib.EFlatFolderNaming FlatFolderNaming { get; set; } = lib.EFlatFolderNaming.author_book;

            public bool WithSeriesTitle { get; set; } = true;

            public byte NumDigitsSeriesSeqNo { get; set; } = 2;

            public bool FullCaptionBookFolder { get; set; }

            public global::audiamus.aaxconv.lib.EOutFolderConflict OutFolderConflict { get; set; } = lib.EOutFolderConflict.ask;

            public bool ExtraMetaFiles { get; set; }

            public global::audiamus.aaxconv.lib.EOnlineUpdate OnlineUpdate { get; set; } = lib.EOnlineUpdate.promptForInstall;

            public uint ShortChapterSec { get; set; } = 25;

            public uint VeryShortChapterSec { get; set; } = 10;

            public global::audiamus.aaxconv.lib.EVerifyAdjustChapterMarks VerifyAdjustChapterMarks { get; set; } = lib.EVerifyAdjustChapterMarks.splitChapterOrTimeMode;

            public bool Latin1EncodingForPlaylist { get; set; }

            public bool IntermedCopySingle { get; set; }

            public global::audiamus.aaxconv.lib.EFixAACEncoding FixAACEncoding { get; set; } = lib.EFixAACEncoding.withIntermediateCopy;

            public global::audiamus.aaxconv.lib.ENamedChapters NamedChapters { get; set; } = lib.ENamedChapters.yes;

            public bool VariableBitRate { get; set; }

            public global::audiamus.aaxconv.lib.EReducedBitRate ReducedBitRate { get; set; } = lib.EReducedBitRate.off;

            public bool AutoLaunchPlayer { get; set; } = true;

            public bool M4B { get; set; } = true;

            public global::audiamus.aaxconv.lib.EAaxCopyMode AaxCopyMode { get; set; } = lib.EAaxCopyMode.no;

            public string AaxCopyDirectory { get; set; }

            public string Version { get; set; }

            public global::System.Nullable<System.Boolean> ShowStartupTip { get; set; }

            public int SettingsTab { get; set; } = 0;

            public global::audiamus.aaxconv.lib.EPreferEmbeddedChapterTimes PreferEmbeddedChapterTimes { get; set; } = lib.EPreferEmbeddedChapterTimes.no;

            public global::audiamus.aaxconv.lib.ERoleTagAssignment TagArtist { get; set; } = lib.ERoleTagAssignment.author__narrator__;

            public global::audiamus.aaxconv.lib.ERoleTagAssignment TagAlbumArtist { get; set; } = lib.ERoleTagAssignment.none;

            public global::audiamus.aaxconv.lib.ERoleTagAssignment TagComposer { get; set; } = lib.ERoleTagAssignment.none;

            public global::audiamus.aaxconv.lib.ERoleTagAssignment TagConductor { get; set; } = lib.ERoleTagAssignment.none;

            public string OnlineUpdateUrl { get; set; }

            public bool OnlineUpdateDebug { get; set; }

            public string OnlineUpdateOthersDeclined { get; set; }

            public bool ConvertByFileDate { get; set; }

      public void FixNarrator () {
        TagArtist = fixNarrator (TagArtist);
        TagAlbumArtist = fixNarrator (TagAlbumArtist);
        TagComposer = fixNarrator (TagComposer);
        TagConductor = fixNarrator (TagConductor);
        Narrator = null;
      }

        public void Save()
        {
            var serialized = JsonConvert.SerializeObject(this, Formatting.Indented);
            Directory.CreateDirectory(Path.GetDirectoryName(GEN_PATH));
            File.WriteAllText(GEN_PATH, serialized);
        }

        private ERoleTagAssignment fixNarrator (ERoleTagAssignment role) {
        bool narrator = Narrator ?? false;
        switch (role) {
          default:
            return role;
          case ERoleTagAssignment.author__narrator__:
            if (narrator)
              return ERoleTagAssignment.author_narrator;
            else
              return ERoleTagAssignment.author;
          case ERoleTagAssignment.__narrator__:
            if (narrator)
              return ERoleTagAssignment.narrator;
            else
              return ERoleTagAssignment.none;
        }

      }
    }
  }
}
