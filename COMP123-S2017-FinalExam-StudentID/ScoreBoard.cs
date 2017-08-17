using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
* Name: Sushmita Nandalan
* Date: August 17, 2017
* Student ID: 300923159
* Description: This is ScoreBoard class. 
* Version: 0.2  - Added Constructor and UpdateTime method
*/
namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        //PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox
        {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                _finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                ScoreTextBox.Text = Convert.ToString(this._score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return _scoreTextBox;
            }
            set
            {
                _scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                TimeTextBox.Text = Convert.ToString(_time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return _timeTextBox;
            }
            set
            {
                _timeTextBox = value;
            }
        }

        // CONSTRUCTOR
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this._scoreTextBox = scoreTextBox;
            this._timeTextBox = timeTextBox;
            this._finalScoreTextBox = finalScoreTextBox;
        }

        //PUBLIC METHODS
        public void UpdateTime()
        {
            Time = Convert.ToInt32(Time);
            Time -= 1;
            TimeTextBox.Text = Convert.ToString(Time);
        }
    }
}
