using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._2
{
    class Song
    {
        private string _nameSong;
        public string NameSong
        {
            get
            {
                return _nameSong;
            }
            set
            {
                _nameSong = value;
            }
        }

        private double _duratinSong;

        public double DurationSong
        {
            get
            {
                return _duratinSong;
            }
            set
            {
                _duratinSong = value;
            }
        }

        private string _authorSong;
        public string AuthorSong
        {
            get
            {
                return _authorSong;
            }
            set
            {
                _authorSong = value;
            }
        }

        private int _yearIssue;

        public int YearIssue
        {
            get
            {
                return _yearIssue;
            }
            set
            {
                _yearIssue = value;
            }
        }

    }
}
