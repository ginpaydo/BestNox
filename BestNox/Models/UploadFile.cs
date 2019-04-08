﻿using EfCore.Shaman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestNox.Models
{
    /// <summary>
    /// アップロードファイルのデータ
    /// </summary>
    public class UploadFile : IEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        [Required]
        public string Comment { get; set; }

        /// <summary>
        /// ファイル名
        /// </summary>
        [Required]
        public string Filename { get; set; }

        /// <summary>
        /// 公開設定
        /// </summary>
        [Required]
        public int IsPublic { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; set; }

        #region 共通項目
        /// <summary>
        /// 登録者
        /// </summary>
        [Index, DisplayName("登録者")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// 登録日時
        /// </summary>
        [DisplayName("登録日時")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [DisplayName("更新者")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        [DisplayName("更新日時")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// 論理削除フラグ
        /// </summary>
        [DisplayName("論理削除")]
        public bool IsDeleted { get; set; }
        #endregion
    }
}
