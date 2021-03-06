﻿

using System;
using System.Dynamic;
using System.Web.Mvc;
using RFO.AspNet.Utilities.Attribute;
using RFO.AspNet.Utilities.ActionResultBuilder;
using RFO.Common.Utilities.Logging;

namespace RFO.Website.Areas.Admin.Controllers
{
    /// <summary>
    /// The controller takes responsibility to handle requests regardless User management
    /// </summary>
    public class UserManagementController : AbstractAdminController
    {
        #region Override of AbstractAdminController
        
        /// <summary>
        /// Gets the detail view template.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        protected override string GetDetailViewTemplate(int id)
        {
            return this.RenderPartialViewToString("~/Areas/Admin/Views/UserManagement/_PartialDetail.cshtml", id);
        }

        /// <summary>
        /// Gets the records view template.
        /// </summary>
        /// <returns></returns>
        protected override string GetRecordsViewTemplate()
        {
            dynamic viewModel = new ExpandoObject();
            return this.RenderPartialViewToString("~/Areas/Admin/Views/UserManagement/_PartialList.cshtml", viewModel);
        }

        #endregion
        
    }
}

