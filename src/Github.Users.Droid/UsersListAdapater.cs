using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Github.Users.Common.Models;
using Github.Users.Common.Utils;

namespace Github.Users.Droid
{
    public class UsersListAdapater : BaseAdapter<User>
    {
        private readonly IEnumerable<User> _users;
        private Activity _context;

        public UsersListAdapater(Activity context, IEnumerable<User> users) : base()
        {
            context.IsNull();
            users.IsNull();

            _context = context;
            _users = users;
        }

        public override long GetItemId(int position)
        {
            return this[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var user = this[position];

            var view = convertView ?? _context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = user.Name;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = user.Company.Name;

            return view;
        }

        public override int Count => _users.Count();

        public override User this[int position] => _users.ElementAt(position);
    }
}