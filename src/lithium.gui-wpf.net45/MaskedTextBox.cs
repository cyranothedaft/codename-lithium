/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



namespace lithium.gui_wpf.net45 {
   /// <summary>
   /// Masked textbox control is a text box that can have a mask for the text
   /// </summary>
   internal sealed class MaskedTextBox : TextBox {
      private string _mask;
      private MaskedTextProvider _maskProvider;


      /// <summary>
      /// Gets or sets the mask to apply to the textbox
      /// </summary>
      public string Mask {
         get { return _mask; }
         set {
            string oldValue = _mask;
            _mask = value;
            if ( _mask != oldValue ) {
               initMaskProvider(_mask);
               refreshText();
            }
         }
      }


      private void initMaskProvider(string mask) {
         _maskProvider = new MaskedTextProvider(mask, CultureInfo.InvariantCulture, true);
      }


      //
//      /// <summary>
//      /// Dependency property to store the mask to apply to the textbox
//      /// </summary>
//      public static readonly DependencyProperty MaskProperty =
//         DependencyProperty.Register("Mask", typeof( string ), typeof( MaskedTextBox ), new UIPropertyMetadata(null, MaskChanged));
//
//      //callback for when the Mask property is changed
//      private static void MaskChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) {
//         //make sure to update the text if the mask changes
//         MaskedTextBox textBox = ( MaskedTextBox )sender;
//         textBox.RefreshText(textBox.MaskProvider, 0);
//      }

//      /// <summary>
//      /// Static Constructor
//      /// </summary>
//      static MaskedTextBox() {
//         //override the meta data for the Text Proeprty of the textbox 
//         FrameworkPropertyMetadata metaData = new FrameworkPropertyMetadata();
//         metaData.CoerceValueCallback = ForceText;
//         TextProperty.OverrideMetadata(typeof( MaskedTextBox ), metaData);
//      }


      //force the text of the control to use the mask
      private static object ForceText(DependencyObject sender, object value) {
         MaskedTextBox textBox = ( MaskedTextBox )sender;
         if ( textBox.Mask != null ) {
            MaskedTextProvider provider = new MaskedTextProvider(textBox.Mask);
            provider.Set(( string )value);
            return provider.ToDisplayString();
         }
         else {
            return value;
         }
      }


//      ///<summary>
//      /// Default  constructor
//      ///</summary>
//      public MaskedTextBox() {
//         //cancel the paste and cut command
//         CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, null, CancelCommand));
//         CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, null, CancelCommand));
//      }
//
//
//      //cancel the command
//      private static void CancelCommand(object sender, CanExecuteRoutedEventArgs e) {
//         e.CanExecute = false;
//         e.Handled = true;
//      }


      /// <summary>
      /// override this method to replace the characters enetered with the mask
      /// </summary>
      /// <param name="e">Arguments for event</param>
      protected override void OnPreviewTextInput(TextCompositionEventArgs e) {
         //if the text is readonly do not add the text
         if ( IsReadOnly ) {
            e.Handled = true;
            return;
         }

         if ( _maskProvider != null ) {
            int position = SelectionStart;
            if ( position < Text.Length ) {
               position = GetNextCharacterPosition(position);

               if ( Keyboard.IsKeyToggled(Key.Insert) ) {
                  if ( _maskProvider.Replace(e.Text, position) )
                     position++;
               }
               else {
                  if ( _maskProvider.InsertAt(e.Text, position) )
                     position++;
               }

               position = GetNextCharacterPosition(position);
            }

            RefreshText(_maskProvider, position);
            e.Handled = true;
         }

         base.OnPreviewTextInput(e);
      }


      /// <summary>
      /// override the key down to handle delete of a character
      /// </summary>
      /// <param name="e">Arguments for the event</param>
      protected override void OnPreviewKeyDown(KeyEventArgs e) {
         base.OnPreviewKeyDown(e);

         if ( _maskProvider == null ) return;

         int position = SelectionStart;
         int selectionlength = SelectionLength;
         // If no selection use the start position else use end position
         int endposition = ( selectionlength == 0 ) ? position : position + selectionlength - 1;

         if ( e.Key == Key.Delete && position < Text.Length ) //handle the delete key
         {
            if ( _maskProvider.RemoveAt(position, endposition) )
               RefreshText(_maskProvider, position);

            e.Handled = true;
         }

         else if ( e.Key == Key.Space ) {
            if ( _maskProvider.InsertAt(" ", position) )
               RefreshText(_maskProvider, position);
            e.Handled = true;
         }

         else if ( e.Key == Key.Back ) //handle the back space
         {
            if ( ( position > 0 ) && ( selectionlength == 0 ) ) {
               position--;
               if ( _maskProvider.RemoveAt(position) )
                  RefreshText(_maskProvider, position);
            }

            if ( selectionlength != 0 ) {
               if ( _maskProvider.RemoveAt(position, endposition) ) {
                  if ( position > 0 )
                     position--;

                  RefreshText(_maskProvider, position);
               }
            }

            e.Handled = true;
         }
      }


      private void refreshText() {
         int pos = SelectionStart;
         Text = _maskProvider.ToDisplayString();
         SelectionStart = pos;
      }
      //refreshes the text of the textbox
      private void RefreshText(MaskedTextProvider provider, int position) {
         Text = provider.ToDisplayString();
         SelectionStart = position;
      }


      //gets the next position in the textbox to move
      private int GetNextCharacterPosition(int startPosition) {
         if ( _maskProvider == null ) return startPosition;
         int position = _maskProvider.FindEditPositionFrom(startPosition, true);
         if ( position == -1 )
            return startPosition;
         else
            return position;
      }
   }
}
*/