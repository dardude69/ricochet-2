﻿using System;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace VRC.Udon.Editor.ProgramSources.UdonGraphProgram.UI
{
    public class UnsignedLongField : BaseField<ulong>
    {
        public UnsignedLongField():base(null,null)
        {
            // Set up styling
            AddToClassList("UdonValueField");
            
            // Create Char Editor and listen for changes
            IntegerField field = new IntegerField();
            field.RegisterValueChangedCallback(
                e =>
                    value = Convert.ToUInt64(e.newValue));

            Add(field);
        }
    }
}