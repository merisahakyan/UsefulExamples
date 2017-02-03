
##Crazy Button
![](https://github.com/merisahakyan/UsefulExamples/blob/master/CrazyButton/button.gif)
</br>
```cs
private void button1_MouseMove(object sender, MouseEventArgs e)
{
    Point coordinates = Cursor.Position;
    Random r = new Random();
    int bx, by;
    bx = r.Next(button1.Width, ClientSize.Width-button1.Width;
    by = r.Next(button1.Height,ClientSize.Height-button1.Height);
    button1.Location = new Point(bx, by);
    label1.Location = new Point((ClientSize.Width - label1.Text.Length) / 2, 20);
}
```
