// variable to set up concatenation to write
string line = "";
// get StreamWriter and write to file inside the brackets
StreamWriter sw = new StreamWriter("test.csv");
  // loop through the list 
  foreach (Song song in playlist.SongList)
  {
    // line variable that has been concatenated
    line = song.id.ToString() + "," + song.path + "," + song.rating.ToString() + "," + song.tags.ToString();
    // write to file whats in the line variable
    sw.WriteLine(line);
  }
// close StreamWriter
sw.Close();

// using a saveFileDialog
 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
  string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
  saveFileDialog1.Filter = filter;
  string line = "";
  StreamWriter sw = null;
  try
  {
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
      filter = saveFileDialog1.FileName;
      sw = new StreamWriter(filter);
      foreach (Song song in playlist.SongList)
        {
          line = song.id.ToString() + "," + song.path + "," + song.rating.ToString() + "," + song.tags.ToString();
          sw.WriteLine(line);
        }
    }
      sw.Close();
      MessageBox.Show("File \"" + line + "\"");
  }
  catch (Exception ex)
  {
    throw new ApplicationException("This program didn't work", ex);
  }