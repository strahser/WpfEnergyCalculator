

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.Tests;
using WpfEnergyCalculator.ViewModel;

namespace WpfEnergyCalculator.ViewModels
{    public class ConnectionViewModel : ViewModelBase

    {
        readonly StructureInstance StructureInstanceData;
        public ConnectionViewModel(StructureInstance _structuralInstanceData)
        {
            # region db
            StructureInstanceData = _structuralInstanceData;
            _structure_category_list = DBSample._structure_category_list;
            _selected_category = StructureInstanceData.StructureProperty.StructureCategory;
            StructurePropertyList = GetFiltredConstructionProperty(SelectedCategory.StructureCategoryId);
            _selected_property = StructureInstanceData.StructureProperty;
            _selected_orientation_type = StructureInstanceData.StructureInstanceOrientation;
            _area = StructureInstanceData.StructureInstanceArea;
            #endregion
        }
        #region private filds
        private ObservableCollection<StructureCategory> _structure_category_list;
        private ObservableCollection<StructurePropertys> _structure_property_list;
        private StructureCategory _selected_category;
        private StructurePropertys _selected_property;
        private double _area;
        private string _selected_orientation_type;
        #endregion

        #region Property changes
        public ObservableCollection<StructureCategory> StructureCategoryList
        {
            get { return _structure_category_list; }
            set {
                _structure_category_list = value;
                OnPropertyChanged("StructureCategoryList");                
            }
        }

        public ObservableCollection<StructurePropertys> StructurePropertyList        {
            get { return _structure_property_list;
            
            }
            set
            {
                _structure_property_list = value;
                OnPropertyChanged("StructurePropertyList");                
            }
        }

        public List<string> PossibleOrientationTypes
        {
            get => StructureOrientation.GetPossibleOrientationTypes();
        }


        public StructureCategory SelectedCategory
        {
            get { return _selected_category; }
            set
            {
                _selected_category = value;
                OnPropertyChanged("SelectedCategory");
                OnPropertyChanged("AllowCategorySelection");
                StructurePropertyList = GetFiltredConstructionProperty(SelectedCategory.StructureCategoryId);
            }
        }

        public double Area
        {
            get { return _area; }
            set {
                _area = value;
                OnPropertyChanged("Area");
                    
                    }
        }
        public StructurePropertys SelectedProperty
        {
            get { return _selected_property; }
            set
            {
                _selected_property = value;
                OnPropertyChanged("SelectedProperty");
            }
        }
        
        public string SelectedOrientationType
        {
            get { return _selected_orientation_type; }
            set
            {
                _selected_orientation_type = value;
                OnPropertyChanged("SelectedOrientationType");
            }
        }
        #endregion

        #region filter DB property
        public bool AllowCategorySelection
        {
            //get { return SelectedCategory != null; }
            get { return true; }
        }

        private ObservableCollection<StructurePropertys> GetFiltredConstructionProperty(int _SelectedCategory_id)
        {
            ObservableCollection<StructurePropertys> temp_list = new ObservableCollection<StructurePropertys>();
            if (AllowCategorySelection)
            {
                foreach (StructurePropertys val in DBSample._structure_property_list)
                {
                    if (val.StructureCategory.StructureCategoryId == _SelectedCategory_id)
                    {
                        temp_list.Add(val);
                    }
                }

            }
            return temp_list;

        }
        #endregion
    }
}
