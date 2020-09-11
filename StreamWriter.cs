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