using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFHotelBooking.Models;
using EFHotelBooking.Services;

namespace EFHotelBooking.Forms.Room
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                EFHotelBooking.Models.Room room = new EFHotelBooking.Models.Room();
                room.Name = txtName.Text.Trim();
                room.Description = txtDescription.Text.Trim();
                room.Price = Convert.ToDecimal(txtPrice.Text.Trim());
                room.Capacity = Convert.ToInt32(txtCapacity.Text.Trim());

                RoomServices roomServices = new RoomServices();
                roomServices.AddRoom(room);
                MessageBox.Show(room.Name + " isimli oda basariyla eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Oda eklerken bir hata meydana geldi. Lutfen tekrar deneyiniz");
            }


        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {

            LoadData();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dtGridRooms.CurrentRow.Cells["id"].Value);

            RoomServices roomServices = new RoomServices();
            roomServices.DeleteRoom(selectedId);
            LoadData();
        }


        void LoadData()
        {
            RoomServices roomServices = new RoomServices();
            List<EFHotelBooking.Models.Room> rooms = roomServices.GetAllRooms();
            dtGridRooms.DataSource = rooms;

            lblTotal.Text = rooms.Count.ToString() + " oda listeleniyor";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal min = Convert.ToDecimal(txtMin.Text);
            decimal max = Convert.ToDecimal(txtMax.Text);

            RoomServices roomServices = new RoomServices();
            List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByPriceRate(min, max);

            dtGridRooms.DataSource = rooms;

            lblTotal.Text = rooms.Count.ToString() + " oda listeleniyor";
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioIsAvailable_CheckedChanged(object sender, EventArgs e)
        {
            RoomServices roomServices = new RoomServices();
            List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByStatus(true);
            dtGridRooms.DataSource = rooms;
            lblTotal.Text = rooms.Count.ToString() + " oda listeleniyor";

        }

        private void radioIsNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            RoomServices roomServices = new RoomServices();
            List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByStatus(false);
            dtGridRooms.DataSource = rooms;
            lblTotal.Text = rooms.Count.ToString() + " oda listeleniyor";
        }
    }
}
