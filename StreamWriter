 string line = "";

  StreamWriter sw = new StreamWriter("test.csv");

  foreach (Song song in playlist.SongList)
  {
    line = song.id.ToString() + "," + song.path + "," + song.rating.ToString() + "," + song.tags.ToString();

    sw.WriteLine(line);
  }
  sw.Close();