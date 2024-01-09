using System;
using System.Drawing;
using System.Windows.Forms;

ApplicationConfiguration.Initialize();
var form = new Form();
form.WindowState = FormWindowState.Maximized;
form.BackColor = Color.White;

Label label = new Label();
label.Text = "7777";

Button button = new Button();
button.Text = "click here";
button.Width = 200;
button.Location = new Point(400, 400);
button.Click +=(o, e) =>{
    button.Location = new Point(
        Random.Shared.Next(form.Width-800)+400,
        Random.Shared.Next(form.Height-200)+100
    );
    button.BackColor = Color.FromArgb(Random.Shared.Next(255), Random.Shared.Next(255), Random.Shared.Next(255));
    label.Text = (int.Parse(label.Text)+1).ToString();
};
form.Controls.Add(button);
form.Controls.Add(label);

Application.Run(form);