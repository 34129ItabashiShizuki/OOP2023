using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double gramValue,poundValue;

        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }
        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値(単位)
        public GramConversion CurrentGramConversion { get; set; }

        //下のComboBoxで選択されている値(単位)
        public PoundConversion CurrentPoundConversion { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand PoundToGram { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand GramUnitToPound { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentGramConversion = GramConversion.Units.First();
            this.CurrentPoundConversion = PoundConversion.Units.First();

            this.GramUnitToPound = new DelegateCommand(
                () => this.PoundValue = this.CurrentPoundConversion.FromGramUnit(
                    this.CurrentGramConversion, this.GramValue));

            this.PoundToGram = new DelegateCommand(
                () => this.GramValue = this.CurrentGramConversion.FromPoundUnit(
                    this.CurrentPoundConversion, this.PoundValue));
        }
    }
}
