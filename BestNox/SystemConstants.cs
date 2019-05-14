﻿namespace BestNox
{
    /// <summary>
    /// システム設定
    /// </summary>
    public static class SystemConstants
    {
        // 発行前に設定する
        /// <summary>
        /// 使用ポート
        /// Program.csで使用するので、外出し不可？
        /// </summary>
        public const string Port = "http://0.0.0.0:8000";

        /// <summary>
        /// サイトアドレス
        /// （設定ファイルに外出し可？）
        /// </summary>
        public const string SiteUrl = "https://localhost:44307/";

        /////////////////////////////////////////////////////////

        /// <summary>
        /// 環境：開発系
        /// </summary>
        public const string EnvDevelopment = "Development";
        /// <summary>
        /// 環境：本番系
        /// </summary>
        public const string EnvProduction = "Production";

        /// <summary>
        /// 現在のDB接続設定
        /// 詳細はappsettings.json
        /// </summary>
        public const string Connection = "DefaultConnection";

        /// <summary>
        /// DBパスワード環境変数名
        /// </summary>
        public const string DbPasswordEnv = "DATABASE_PASSWORD";

        /// <summary>
        /// 展示用モードかの環境変数名
        /// </summary>
        public const string IsDemoEnv = "IS_DEMO";

        /// <summary>
        /// ページタイトル
        /// </summary>
        public const string Title = "BestNox";

        /// <summary>
        /// 初期値設定ユーザ名
        /// </summary>
        public const string DefaultParameterUserName = "default";

        /// <summary>
        /// 管理者権限名
        /// </summary>
        public const string Administrator = "Administrator";

        /// <summary>
        /// ファイル未選択
        /// </summary>
        public const string NoFileError = "ファイルが選択されていません";

        /// <summary>
        /// コメント未入力
        /// </summary>
        public const string NoComment = "コメントなし";

        /// <summary>
        /// 公開ファイルアップロード先
        /// </summary>
        public const string PublicUploadsDirectry = "wwwroot/" + PublicUploads;

        /// <summary>
        /// 公開ファイルアップロード先
        /// </summary>
        public const string PublicUploads = "PublicUploads";

        /// <summary>
        /// 非公開ファイルアップロード先
        /// </summary>
        public const string PrivateUploadsDirectry = "PrivateUploads";

        /// <summary>
        /// パスワードの確認誤りメッセージ
        /// </summary>
        public const string ConfirmPasswordError = "パスワードが一致していません";

        /// <summary>
        /// アプリケーション設定：システムパラメータ初期値
        /// </summary>
        public const string DefaultParameters = "DefaultParameters";
        /// <summary>
        /// システムパラメータ：分類コード：分類
        /// </summary>
        public const int SystemPatameterCategory = 1;
        /// <summary>
        /// システムパラメータ：分類コード：オンラインメモ
        /// </summary>
        public const int SystemPatameterMemo = 2;
        /// <summary>
        /// システムパラメータ：分類コード：メモ一覧の背景色
        /// </summary>
        public const int SystemPatameterMemoBack = 3;
    }
}
