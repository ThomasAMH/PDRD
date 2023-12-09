using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PDRD.Data;
using System;
using System.Linq;

namespace PDRD.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PDRDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PDRDContext>>()))
            {
                // Look for any existing hymns
                if (context.Hymn.Any())
                {
                    return;   // DB has been seeded, no action needed
                }
                else // DB not seeded, add data
                {
                    context.Hymn.AddRange(
                    new Hymn {
                    HymnName = "The Morning Breaks",
                    HymnNumber = 1
                    },
                    new Hymn {
                    HymnName = "The Spirit of God",
                    HymnNumber = 2
                    },
                    new Hymn {
                    HymnName = "Now Let Us Rejoice",
                    HymnNumber = 3
                    },
                    new Hymn {
                    HymnName = "Truth Eternal",
                    HymnNumber = 4
                    },
                    new Hymn {
                    HymnName = "High on the Mountain Top",
                    HymnNumber=5
                    },
                    new Hymn {
                    HymnName = "Redeemer of Israel",
                    HymnNumber = 6
                    },
                    new Hymn {
                    HymnName = "Israel, Israel, God Is Calling",
                    HymnNumber = 7
                    },
                    new Hymn {
                    HymnName = "Awake and Arise",
                    HymnNumber = 8
                    },
                    new Hymn {
                    HymnName = "Come, Rejoice",
                    HymnNumber = 9
                    },
                    new Hymn {
                    HymnName = "Come, Sing to the Lord",
                    HymnNumber = 10
                    },
                    new Hymn {
                    HymnName = "What Was Witnessed in the Heavens?",
                    HymnNumber = 11
                    },
                    new Hymn {
                    HymnName = "’Twas Witnessed in the Morning Sky",
                    HymnNumber = 12
                    },
                    new Hymn {
                    HymnName = "An Angel from on High",
                    HymnNumber = 13
                    },
                    new Hymn {
                    HymnName = "Sweet Is the Peace the Gospel Brings",
                    HymnNumber = 14
                    },
                    new Hymn {
                    HymnName = "I Saw a Mighty Angel Fly",
                    HymnNumber = 15
                    },
                    new Hymn {
                    HymnName = "What Glorious Scenes Mine Eyes Behold",
                    HymnNumber = 16
                    },
                    new Hymn {
                    HymnName = "Awake, Ye Saints of God, Awake!",
                    HymnNumber = 17
                    },
                    new Hymn {
                    HymnName = "The Voice of God Again Is Heard",
                    HymnNumber = 18
                    },
                    new Hymn {
                    HymnName = "We Thank Thee, O God, for a Prophet",
                    HymnNumber = 19
                    },
                    new Hymn {
                    HymnName = "God of Power, God of Right",
                    HymnNumber = 20
                    },
                    new Hymn {
                    HymnName = "Come, Listen to a Prophet’s Voice",
                    HymnNumber = 21
                    },
                    new Hymn {
                    HymnName = "We Listen to a Prophet’s Voice",
                    HymnNumber = 22
                    },
                    new Hymn {
                    HymnName = "We Ever Pray for Thee",
                    HymnNumber = 23
                    },
                    new Hymn {
                    HymnName = "God Bless Our Prophet Dear",
                    HymnNumber = 24
                    },
                    new Hymn {
                    HymnName = "Now We’ll Sing with One Accord",
                    HymnNumber = 25
                    },
                    new Hymn {
                    HymnName = "Joseph Smith’s First Prayer",
                    HymnNumber = 26
                    },
                    new Hymn {
                    HymnName = "Praise to the Man",
                    HymnNumber = 27
                    },
                    new Hymn {
                    HymnName = "Saints, Behold How Great Jehovah",
                    HymnNumber = 28
                    },
                    new Hymn {
                    HymnName = "A Poor Wayfaring Man of Grief",
                    HymnNumber = 29
                    },
                    new Hymn {
                    HymnName = "Come, Come, Ye Saints",
                    HymnNumber = 30
                    },
                    new Hymn {
                    HymnName = "O God, Our Help in Ages Past",
                    HymnNumber = 31
                    },
                    new Hymn {
                    HymnName = "The Happy Day at Last Has Come",
                    HymnNumber = 32
                    },
                    new Hymn {
                    HymnName = "Our Mountain Home So Dear",
                    HymnNumber = 33
                    },
                    new Hymn {
                    HymnName = "O Ye Mountains High",
                    HymnNumber = 34
                    },
                    new Hymn {
                    HymnName = "For the Strength of the Hills",
                    HymnNumber = 35
                    },
                    new Hymn {
                    HymnName = "They, the Builders of the Nation",
                    HymnNumber = 36
                    },
                    new Hymn {
                    HymnName = "The Wintry Day, Descending to Its Close",
                    HymnNumber = 37
                    },
                    new Hymn {
                    HymnName = "Come, All Ye Saints of Zion",
                    HymnNumber = 38
                    },
                    new Hymn {
                    HymnName = "O Saints of Zion",
                    HymnNumber = 39
                    },
                    new Hymn {
                    HymnName = "Arise, O Glorious Zion",
                    HymnNumber = 40
                    },
                    new Hymn {
                    HymnName = "Let Zion in Her Beauty Rise",
                    HymnNumber = 41
                    },
                    new Hymn {
                    HymnName = "Hail to the Brightness of Zion’s Glad Morning!",
                    HymnNumber = 42
                    },
                    new Hymn {
                    HymnName = "Zion Stands with Hills Surrounded",
                    HymnNumber = 43
                    },
                    new Hymn {
                    HymnName = "Beautiful Zion, Built Above",
                    HymnNumber = 44
                    },
                    new Hymn {
                    HymnName = "Lead Me into Life Eternal",
                    HymnNumber = 45
                    },
                    new Hymn {
                    HymnName = "Glorious Things of Thee Are Spoken",
                    HymnNumber = 46
                    },
                    new Hymn {
                    HymnName = "We Will Sing of Zion",
                    HymnNumber = 47
                    },
                    new Hymn {
                    HymnName = "Glorious Things Are Sung of Zion",
                    HymnNumber = 48
                    },
                    new Hymn {
                    HymnName = "AdamondiAhman",
                    HymnNumber = 49
                    },
                    new Hymn {
                    HymnName = "Come, Thou Glorious Day of Promise",
                    HymnNumber = 50
                    },
                    new Hymn {
                    HymnName = "Sons of Michael, He Approaches",
                    HymnNumber = 51
                    },
                    new Hymn {
                    HymnName = "The Day Dawn Is Breaking",
                    HymnNumber = 52
                    },
                    new Hymn {
                    HymnName = "Let Earth's Inhabitants Rejoice",
                    HymnNumber=53
                    },
                    new Hymn {
                    HymnName = "Behold, the Mountain of the Lord",
                    HymnNumber = 54
                    },
                    new Hymn {
                    HymnName = "Lo, the Mighty God Appearing!",
                    HymnNumber = 55
                    },
                    new Hymn {
                    HymnName = "Softly Beams the Sacred Dawning",
                    HymnNumber = 56
                    },
                    new Hymn {
                    HymnName = "We’re Not Ashamed to Own Our Lord",
                    HymnNumber = 57
                    },
                    new Hymn {
                    HymnName = "Come, Ye Children of the Lord",
                    HymnNumber = 58
                    },
                    new Hymn {
                    HymnName = "Come, O Thou King of Kings",
                    HymnNumber = 59
                    },
                    new Hymn {
                    HymnName = "Battle Hymn of the Republic",
                    HymnNumber = 60
                    },
                    new Hymn {
                    HymnName = "Raise Your Voices to the Lord",
                    HymnNumber = 61
                    },
                    new Hymn {
                    HymnName = "All Creatures of Our God and King",
                    HymnNumber = 62
                    },
                    new Hymn {
                    HymnName = "Great King of Heaven",
                    HymnNumber = 63
                    },
                    new Hymn {
                    HymnName = "On This Day of Joy and Gladness",
                    HymnNumber = 64
                    },
                    new Hymn {
                    HymnName = "Come, All Ye Saints Who Dwell on Earth",
                    HymnNumber = 65
                    },
                    new Hymn {
                    HymnName = "Rejoice, the Lord Is King!",
                    HymnNumber = 66
                    },
                    new Hymn {
                    HymnName = "Glory to God on High",
                    HymnNumber = 67
                    },
                    new Hymn {
                    HymnName = "A Mighty Fortress Is Our God",
                    HymnNumber = 68
                    },
                    new Hymn {
                    HymnName = "All Glory, Laud, and Honor",
                    HymnNumber = 69
                    },
                    new Hymn {
                    HymnName = "Sing Praise to Him",
                    HymnNumber = 70
                    },
                    new Hymn {
                    HymnName = "With Songs of Praise",
                    HymnNumber = 71
                    },
                    new Hymn {
                    HymnName = "Praise to the Lord, the Almighty",
                    HymnNumber = 72
                    },
                    new Hymn {
                    HymnName = "Praise the Lord with Heart and Voice",
                    HymnNumber = 73
                    },
                    new Hymn {
                    HymnName = "Praise Ye the Lord",
                    HymnNumber = 74
                    },
                    new Hymn {
                    HymnName = "In Hymns of Praise",
                    HymnNumber = 75
                    },
                    new Hymn {
                    HymnName = "God of Our Fathers, We Come unto Thee",
                    HymnNumber = 76
                    },
                    new Hymn {
                    HymnName = "Great Is the Lord",
                    HymnNumber = 77
                    },
                    new Hymn {
                    HymnName = "God of Our Fathers, Whose Almighty Hand",
                    HymnNumber = 78
                    },
                    new Hymn {
                    HymnName = "With All the Power of Heart and Tongue",
                    HymnNumber = 79
                    },
                    new Hymn {
                    HymnName = "God of Our Fathers, Known of Old",
                    HymnNumber = 80
                    },
                    new Hymn {
                    HymnName = "Press Forward, Saints",
                    HymnNumber = 81
                    },
                    new Hymn {
                    HymnName = "For All the Saints",
                    HymnNumber = 82
                    },
                    new Hymn {
                    HymnName = "Guide Us, O Thou Great Jehovah",
                    HymnNumber = 83
                    },
                    new Hymn {
                    HymnName = "Faith of Our Fathers",
                    HymnNumber = 84
                    },
                    new Hymn {
                    HymnName = "How Firm a Foundation",
                    HymnNumber = 85
                    },
                    new Hymn {
                    HymnName = "How Great Thou Art",
                    HymnNumber = 86
                    },
                    new Hymn {
                    HymnName = "God Is Love",
                    HymnNumber = 87
                    },
                    new Hymn {
                    HymnName = "Great God, Attend While Zion Sings",
                    HymnNumber = 88
                    },
                    new Hymn {
                    HymnName = "The Lord Is My Light",
                    HymnNumber = 89
                    },
                    new Hymn {
                    HymnName = "From All That Dwell below the Skies",
                    HymnNumber = 90
                    },
                    new Hymn {
                    HymnName = "Father, Thy Children to Thee Now Raise",
                    HymnNumber = 91
                    },
                    new Hymn {
                    HymnName = "For the Beauty of the Earth",
                    HymnNumber = 92
                    },
                    new Hymn {
                    HymnName = "Prayer of Thanksgiving",
                    HymnNumber = 93
                    },
                    new Hymn {
                    HymnName = "Come, Ye Thankful People",
                    HymnNumber = 94
                    },
                    new Hymn {
                    HymnName = "Now Thank We All Our God",
                    HymnNumber = 95
                    },
                    new Hymn {
                    HymnName = "Dearest Children, God Is Near You",
                    HymnNumber = 96
                    },
                    new Hymn {
                    HymnName = "Lead, Kindly Light",
                    HymnNumber = 97
                    },
                    new Hymn {
                    HymnName = "I Need Thee Every Hour",
                    HymnNumber = 98
                    },
                    new Hymn {
                    HymnName = "Nearer, Dear Savior, to Thee",
                    HymnNumber = 99
                    },
                    new Hymn {
                    HymnName = "Nearer, My God, to Thee",
                    HymnNumber = 100
                    },
                    new Hymn {
                    HymnName = "Guide Me to Thee",
                    HymnNumber = 101
                    },
                    new Hymn {
                    HymnName = "Jesus, Lover of My Soul",
                    HymnNumber = 102
                    },
                    new Hymn {
                    HymnName = "Precious Savior, Dear Redeemer",
                    HymnNumber = 103
                    },
                    new Hymn {
                    HymnName = "Jesus, Savior, Pilot Me",
                    HymnNumber = 104
                    },
                    new Hymn {
                    HymnName = "Master, the Tempest Is Raging",
                    HymnNumber = 105
                    },
                    new Hymn {
                    HymnName = "God Speed the Right",
                    HymnNumber = 106
                    },
                    new Hymn {
                    HymnName = "Lord, Accept Our True Devotion",
                    HymnNumber = 107
                    },
                    new Hymn {
                    HymnName = "The Lord Is My Shepherd",
                    HymnNumber = 108
                    },
                    new Hymn {
                    HymnName = "The Lord My Pasture Will Prepare",
                    HymnNumber = 109
                    },
                    new Hymn {
                    HymnName = "Cast Thy Burden upon the Lord",
                    HymnNumber = 110
                    },
                    new Hymn {
                    HymnName = "Rock of Ages",
                    HymnNumber = 111
                    },
                    new Hymn {
                    HymnName = "Savior, Redeemer of My Soul",
                    HymnNumber = 112
                    },
                    new Hymn {
                    HymnName = "Our Savior's Love",
                    HymnNumber=113
                    },
                    new Hymn {
                    HymnName = "Come unto Him",
                    HymnNumber = 114
                    },
                    new Hymn {
                    HymnName = "Come, Ye Disconsolate",
                    HymnNumber = 115
                    },
                    new Hymn {
                    HymnName = "Come, Follow Me",
                    HymnNumber = 116
                    },
                    new Hymn {
                    HymnName = "Come unto Jesus",
                    HymnNumber = 117
                    },
                    new Hymn {
                    HymnName = "Ye Simple Souls Who Stray",
                    HymnNumber = 118
                    },
                    new Hymn {
                    HymnName = "Come, We That Love the Lord",
                    HymnNumber = 119
                    },
                    new Hymn {
                    HymnName = "Lean on My Ample Arm",
                    HymnNumber = 120
                    },
                    new Hymn {
                    HymnName = "I’m a Pilgrim, I’m a Stranger",
                    HymnNumber = 121
                    },
                    new Hymn {
                    HymnName = "Though Deepening Trials",
                    HymnNumber = 122
                    },
                    new Hymn {
                    HymnName = "Oh, May My Soul Commune with Thee",
                    HymnNumber = 123
                    },
                    new Hymn {
                    HymnName = "Be Still, My Soul",
                    HymnNumber = 124
                    },
                    new Hymn {
                    HymnName = "How Gentle God's Commands",
                    HymnNumber=125
                    },
                    new Hymn {
                    HymnName = "How Long, O Lord Most Holy and True",
                    HymnNumber = 126
                    },
                    new Hymn {
                    HymnName = "Does the Journey Seem Long?",
                    HymnNumber = 127
                    },
                    new Hymn {
                    HymnName = "When Faith Endures",
                    HymnNumber = 128
                    },
                    new Hymn {
                    HymnName = "Where Can I Turn for Peace?",
                    HymnNumber = 129
                    },
                    new Hymn {
                    HymnName = "Be Thou Humble",
                    HymnNumber = 130
                    },
                    new Hymn {
                    HymnName = "More Holiness Give Me",
                    HymnNumber = 131
                    },
                    new Hymn {
                    HymnName = "God Is in His Holy Temple",
                    HymnNumber = 132
                    },
                    new Hymn {
                    HymnName = "Father in Heaven",
                    HymnNumber = 133
                    },
                    new Hymn {
                    HymnName = "I Believe in Christ",
                    HymnNumber = 134
                    },
                    new Hymn {
                    HymnName = "My Redeemer Lives",
                    HymnNumber = 135
                    },
                    new Hymn {
                    HymnName = "I Know That My Redeemer Lives",
                    HymnNumber = 136
                    },
                    new Hymn {
                    HymnName = "Testimony",
                    HymnNumber = 137
                    },
                    new Hymn {
                    HymnName = "Bless Our Fast, We Pray",
                    HymnNumber = 138
                    },
                    new Hymn {
                    HymnName = "In Fasting We Approach Thee",
                    HymnNumber = 139
                    },
                    new Hymn {
                    HymnName = "Did You Think to Pray?",
                    HymnNumber = 140
                    },
                    new Hymn {
                    HymnName = "Jesus, the Very Thought of Thee",
                    HymnNumber = 141
                    },
                    new Hymn {
                    HymnName = "Sweet Hour of Prayer",
                    HymnNumber = 142
                    },
                    new Hymn {
                    HymnName = "Let the Holy Spirit Guide",
                    HymnNumber = 143
                    },
                    new Hymn {
                    HymnName = "Secret Prayer",
                    HymnNumber = 144
                    },
                    new Hymn {
                    HymnName = "Prayer Is the Soul's Sincere Desire",
                    HymnNumber=145
                    },
                    new Hymn {
                    HymnName = "Gently Raise the Sacred Strain",
                    HymnNumber = 146
                    },
                    new Hymn {
                    HymnName = "Sweet Is the Work",
                    HymnNumber = 147
                    },
                    new Hymn {
                    HymnName = "Sabbath Day",
                    HymnNumber = 148
                    },
                    new Hymn {
                    HymnName = "As the Dew from Heaven Distilling",
                    HymnNumber = 149
                    },
                    new Hymn {
                    HymnName = "O Thou Kind and Gracious Father",
                    HymnNumber = 150
                    },
                    new Hymn {
                    HymnName = "We Meet, Dear Lord",
                    HymnNumber = 151
                    },
                    new Hymn {
                    HymnName = "God Be with You Till We Meet Again",
                    HymnNumber = 152
                    },
                    new Hymn {
                    HymnName = "Lord, We Ask Thee Ere We Part",
                    HymnNumber = 153
                    },
                    new Hymn {
                    HymnName = "Father, This Hour Has Been One of Joy",
                    HymnNumber = 154
                    },
                    new Hymn {
                    HymnName = "We Have Partaken of Thy Love",
                    HymnNumber = 155
                    },
                    new Hymn {
                    HymnName = "Sing We Now at Parting",
                    HymnNumber = 156
                    },
                    new Hymn {
                    HymnName = "Thy Spirit, Lord, Has Stirred Our Souls",
                    HymnNumber = 157
                    },
                    new Hymn {
                    HymnName = "Before Thee, Lord, I Bow My Head",
                    HymnNumber = 158
                    },
                    new Hymn {
                    HymnName = "Now the Day Is Over",
                    HymnNumber = 159
                    },
                    new Hymn {
                    HymnName = "Softly Now the Light of Day",
                    HymnNumber = 160
                    },
                    new Hymn {
                    HymnName = "The Lord Be with Us",
                    HymnNumber = 161
                    },
                    new Hymn {
                    HymnName = "Lord, We Come before Thee Now",
                    HymnNumber = 162
                    },
                    new Hymn {
                    HymnName = "Lord, Dismiss Us with Thy Blessing",
                    HymnNumber = 163
                    },
                    new Hymn {
                    HymnName = "Great God, to Thee My Evening Song",
                    HymnNumber = 164
                    },
                    new Hymn {
                    HymnName = "Abide with Me; 'Tis Eventide",
                    HymnNumber = 165
                    },
                    new Hymn {
                    HymnName = "Abide with Me!",
                    HymnNumber = 166
                    },
                    new Hymn {
                    HymnName = "Come, Let Us Sing an Evening Hymn",
                    HymnNumber = 167
                    },
                    new Hymn {
                    HymnName = "As the Shadows Fall",
                    HymnNumber = 168
                    },
                    new Hymn {
                    HymnName = "As Now We Take the Sacrament",
                    HymnNumber = 169
                    },
                    new Hymn {
                    HymnName = "God, Our Father, Hear Us Pray",
                    HymnNumber = 170
                    },
                    new Hymn {
                    HymnName = "With Humble Heart",
                    HymnNumber = 171
                    },
                    new Hymn {
                    HymnName = "In Humility, Our Savior",
                    HymnNumber = 172
                    },
                    new Hymn {
                    HymnName = "While of These Emblems We Partake",
                    HymnNumber = 173
                    },
                    new Hymn {
                    HymnName = "While of These Emblems We Partake",
                    HymnNumber = 174
                    },
                    new Hymn {
                    HymnName = "O God, the Eternal Father",
                    HymnNumber = 175
                    },
                    new Hymn {
                    HymnName = "'Tis Sweet to Sing the Matchless Love",
                    HymnNumber = 176
                    },
                    new Hymn {
                    HymnName = "'Tis Sweet To Sing the Matchless Love",
                    HymnNumber = 177
                    },
                    new Hymn {
                    HymnName = "O Lord of Hosts",
                    HymnNumber = 178
                    },
                    new Hymn {
                    HymnName = "Again, Our Dear Redeeming Lord",
                    HymnNumber = 179
                    },
                    new Hymn {
                    HymnName = "Father in Heaven, We Do Believe",
                    HymnNumber = 180
                    },
                    new Hymn {
                    HymnName = "Jesus of Nazareth, Savior and King",
                    HymnNumber = 181
                    },
                    new Hymn {
                    HymnName = "We’ll Sing All Hail to Jesus’ Name",
                    HymnNumber = 182
                    },
                    new Hymn {
                    HymnName = "In Remembrance of Thy Suffering",
                    HymnNumber = 183
                    },
                    new Hymn {
                    HymnName = "Upon the Cross of Calvary",
                    HymnNumber = 184
                    },
                    new Hymn {
                    HymnName = "Reverently and Meekly Now",
                    HymnNumber = 185
                    },
                    new Hymn {
                    HymnName = "Again We Meet around the Board",
                    HymnNumber = 186
                    },
                    new Hymn {
                    HymnName = "God Loved Us, So He Sent His Son",
                    HymnNumber = 187
                    },
                    new Hymn {
                    HymnName = "Thy Will, O Lord, Be Done",
                    HymnNumber = 188
                    },
                    new Hymn {
                    HymnName = "O Thou, Before the World Began",
                    HymnNumber = 189
                    },
                    new Hymn {
                    HymnName = "In Memory of the Crucified",
                    HymnNumber = 190
                    },
                    new Hymn {
                    HymnName = "Behold the Great Redeemer Die",
                    HymnNumber = 191
                    },
                    new Hymn {
                    HymnName = "He Died! The Great Redeemer Died",
                    HymnNumber = 192
                    },
                    new Hymn {
                    HymnName = "I Stand All Amazed",
                    HymnNumber = 193
                    },
                    new Hymn {
                    HymnName = "There Is a Green Hill Far Away",
                    HymnNumber = 194
                    },
                    new Hymn {
                    HymnName = "How Great the Wisdom and the Love",
                    HymnNumber = 195
                    },
                    new Hymn {
                    HymnName = "Jesus, Once of Humble Birth",
                    HymnNumber = 196
                    },
                    new Hymn {
                    HymnName = "O Savior, Thou Who Wearest a Crown",
                    HymnNumber = 197
                    },
                    new Hymn {
                    HymnName = "That Easter Morn",
                    HymnNumber = 198
                    },
                    new Hymn {
                    HymnName = "He Is Risen!",
                    HymnNumber = 199
                    },
                    new Hymn {
                    HymnName = "Christ the Lord Is Risen Today",
                    HymnNumber = 200
                    },
                    new Hymn {
                    HymnName = "Joy to the World",
                    HymnNumber = 201
                    },
                    new Hymn {
                    HymnName = "Oh, Come, All Ye Faithful",
                    HymnNumber = 202
                    },
                    new Hymn {
                    HymnName = "Angels We Have Heard on High",
                    HymnNumber = 203
                    },
                    new Hymn {
                    HymnName = "Silent Night",
                    HymnNumber = 204
                    },
                    new Hymn {
                    HymnName = "Once in Royal David’s City",
                    HymnNumber = 205
                    },
                    new Hymn {
                    HymnName = "Away in a Manger",
                    HymnNumber = 206
                    },
                    new Hymn {
                    HymnName = "It Came upon the Midnight Clear",
                    HymnNumber = 207
                    },
                    new Hymn {
                    HymnName = "O Little Town of Bethlehem",
                    HymnNumber = 208
                    },
                    new Hymn {
                    HymnName = "Hark! The Herald Angels Sing",
                    HymnNumber = 209
                    },
                    new Hymn {
                    HymnName = "With Wondering Awe",
                    HymnNumber = 210
                    },
                    new Hymn {
                    HymnName = "While Shepherds Watched Their Flocks",
                    HymnNumber = 211
                    },
                    new Hymn {
                    HymnName = "Far, Far Away on Judea’s Plains",
                    HymnNumber = 212
                    },
                    new Hymn {
                    HymnName = "The First Noel",
                    HymnNumber = 213
                    },
                    new Hymn {
                    HymnName = "I Heard the Bells on Christmas Day",
                    HymnNumber = 214
                    },
                    new Hymn {
                    HymnName = "Ring Out, Wild Bells",
                    HymnNumber = 215
                    },
                    new Hymn {
                    HymnName = "We Are Sowing",
                    HymnNumber = 216
                    },
                    new Hymn {
                    HymnName = "Come, Let Us Anew",
                    HymnNumber = 217
                    },
                    new Hymn {
                    HymnName = "We Give Thee But Thine Own",
                    HymnNumber = 218
                    },
                    new Hymn {
                    HymnName = "Because I Have Been Given Much",
                    HymnNumber = 219
                    },
                    new Hymn {
                    HymnName = "Lord, I Would Follow Thee",
                    HymnNumber = 220
                    },
                    new Hymn {
                    HymnName = "Dear to the Heart of the Shepherd",
                    HymnNumber = 221
                    },
                    new Hymn {
                    HymnName = "Hear Thou Our Hymn, O Lord",
                    HymnNumber = 222
                    },
                    new Hymn {
                    HymnName = "Have I Done Any Good?",
                    HymnNumber = 223
                    },
                    new Hymn {
                    HymnName = "I Have Work Enough to Do",
                    HymnNumber = 224
                    },
                    new Hymn {
                    HymnName = "We Are Marching On to Glory",
                    HymnNumber = 225
                    },
                    new Hymn {
                    HymnName = "Improve the Shining Moments",
                    HymnNumber = 226
                    },
                    new Hymn {
                    HymnName = "There Is Sunshine in My Soul Today",
                    HymnNumber = 227
                    },
                    new Hymn {
                    HymnName = "You Can Make the Pathway Bright",
                    HymnNumber = 228
                    },
                    new Hymn {
                    HymnName = "Today, While the Sun Shines",
                    HymnNumber = 229
                    },
                    new Hymn {
                    HymnName = "Scatter Sunshine",
                    HymnNumber = 230
                    },
                    new Hymn {
                    HymnName = "Father, Cheer Our Souls Tonight",
                    HymnNumber = 231
                    },
                    new Hymn {
                    HymnName = "Let Us Oft Speak Kind Words",
                    HymnNumber = 232
                    },
                    new Hymn {
                    HymnName = "Nay, Speak No Ill",
                    HymnNumber = 233
                    },
                    new Hymn {
                    HymnName = "Jesus, Mighty King in Zion",
                    HymnNumber = 234
                    },
                    new Hymn {
                    HymnName = "Should You Feel Inclined to Censure",
                    HymnNumber = 235
                    },
                    new Hymn {
                    HymnName = "Lord, Accept into Thy Kingdom",
                    HymnNumber = 236
                    },
                    new Hymn {
                    HymnName = "Do What Is Right",
                    HymnNumber = 237
                    },
                    new Hymn {
                    HymnName = "Behold Thy Sons and Daughters, Lord",
                    HymnNumber = 238
                    },
                    new Hymn {
                    HymnName = "Choose the Right",
                    HymnNumber = 239
                    },
                    new Hymn {
                    HymnName = "Know This, That Every Soul Is Free",
                    HymnNumber = 240
                    },
                    new Hymn {
                    HymnName = "Count Your Blessings",
                    HymnNumber = 241
                    },
                    new Hymn {
                    HymnName = "Praise God, from Whom All Blessings Flow",
                    HymnNumber = 242
                    },
                    new Hymn {
                    HymnName = "Let Us All Press On",
                    HymnNumber = 243
                    },
                    new Hymn {
                    HymnName = "Come Along, Come Along",
                    HymnNumber = 244
                    },
                    new Hymn {
                    HymnName = "This House We Dedicate to Thee",
                    HymnNumber = 245
                    },
                    new Hymn {
                    HymnName = "Onward, Christian Soldiers",
                    HymnNumber = 246
                    },
                    new Hymn {
                    HymnName = "We Love Thy House, O God",
                    HymnNumber = 247
                    },
                    new Hymn {
                    HymnName = "Up, Awake, Ye Defenders of Zion",
                    HymnNumber = 248
                    },
                    new Hymn {
                    HymnName = "Called to Serve",
                    HymnNumber = 249
                    },
                    new Hymn {
                    HymnName = "We Are All Enlisted",
                    HymnNumber = 250
                    },
                    new Hymn {
                    HymnName = "Behold! A Royal Army",
                    HymnNumber = 251
                    },
                    new Hymn {
                    HymnName = "Put Your Shoulder to the Wheel",
                    HymnNumber = 252
                    },
                    new Hymn {
                    HymnName = "Like Ten Thousand Legions Marching",
                    HymnNumber = 253
                    },
                    new Hymn {
                    HymnName = "True to the Faith",
                    HymnNumber = 254
                    },
                    new Hymn {
                    HymnName = "Carry On",
                    HymnNumber = 255
                    },
                    new Hymn {
                    HymnName = "As Zion’s Youth in Latter Days",
                    HymnNumber = 256
                    },
                    new Hymn {
                    HymnName = "Rejoice! A Glorious Sound Is Heard",
                    HymnNumber = 257
                    },
                    new Hymn {
                    HymnName = "O Thou Rock of Our Salvation",
                    HymnNumber = 258
                    },
                    new Hymn {
                    HymnName = "Hope of Israel",
                    HymnNumber = 259
                    },
                    new Hymn {
                    HymnName = "Who’s on the Lord’s Side?",
                    HymnNumber = 260
                    },
                    new Hymn {
                    HymnName = "Thy Servants Are Prepared",
                    HymnNumber = 261
                    },
                    new Hymn {
                    HymnName = "Go, Ye Messengers of Glory",
                    HymnNumber = 262
                    },
                    new Hymn {
                    HymnName = "Go Forth with Faith",
                    HymnNumber = 263
                    },
                    new Hymn {
                    HymnName = "Hark, All Ye Nations!",
                    HymnNumber = 264
                    },
                    new Hymn {
                    HymnName = "Arise, O God, and Shine",
                    HymnNumber = 265
                    },
                    new Hymn {
                    HymnName = "The Time Is Far Spent",
                    HymnNumber = 266
                    },
                    new Hymn {
                    HymnName = "How Wondrous and Great",
                    HymnNumber = 267
                    },
                    new Hymn {
                    HymnName = "Come, All Whose Souls Are Lighted",
                    HymnNumber = 268
                    },
                    new Hymn {
                    HymnName = "Jehovah, Lord of Heaven and Earth",
                    HymnNumber = 269
                    },
                    new Hymn {
                    HymnName = "I’ll Go Where You Want Me to Go",
                    HymnNumber = 270
                    },
                    new Hymn {
                    HymnName = "Oh, Holy Words of Truth and Love",
                    HymnNumber = 271
                    },
                    new Hymn {
                    HymnName = "Oh Say, What Is Truth?",
                    HymnNumber = 272
                    },
                    new Hymn {
                    HymnName = "Truth Reflects upon Our Senses",
                    HymnNumber = 273
                    },
                    new Hymn {
                    HymnName = "The Iron Rod",
                    HymnNumber = 274
                    },
                    new Hymn {
                    HymnName = "Men Are That They Might Have Joy",
                    HymnNumber = 275
                    },
                    new Hymn {
                    HymnName = "Come Away to the Sunday School",
                    HymnNumber = 276
                    },
                    new Hymn {
                    HymnName = "As I Search the Holy Scriptures",
                    HymnNumber = 277
                    },
                    new Hymn {
                    HymnName = "Thanks for the Sabbath School",
                    HymnNumber = 278
                    },
                    new Hymn {
                    HymnName = "Thy Holy Word",
                    HymnNumber = 279
                    },
                    new Hymn {
                    HymnName = "Welcome, Welcome, Sabbath Morning",
                    HymnNumber = 280
                    },
                    new Hymn {
                    HymnName = "Help Me Teach with Inspiration",
                    HymnNumber = 281
                    },
                    new Hymn {
                    HymnName = "We Meet Again in Sabbath School",
                    HymnNumber = 282
                    },
                    new Hymn {
                    HymnName = "The Glorious Gospel Light Has Shone",
                    HymnNumber = 283
                    },
                    new Hymn {
                    HymnName = "If You Could Hie to Kolob",
                    HymnNumber = 284
                    },
                    new Hymn {
                    HymnName = "God Moves in a Mysterious Way",
                    HymnNumber = 285
                    },
                    new Hymn {
                    HymnName = "Oh, What Songs of the Heart",
                    HymnNumber = 286
                    },
                    new Hymn {
                    HymnName = "Rise, Ye Saints, and Temples Enter",
                    HymnNumber = 287
                    },
                    new Hymn {
                    HymnName = "How Beautiful Thy Temples, Lord",
                    HymnNumber = 288
                    },
                    new Hymn {
                    HymnName = "Holy Temples on Mount Zion",
                    HymnNumber = 289
                    },
                    new Hymn {
                    HymnName = "Rejoice, Ye Saints of Latter Days",
                    HymnNumber = 290
                    },
                    new Hymn {
                    HymnName = "Turn Your Hearts",
                    HymnNumber = 291
                    },
                    new Hymn {
                    HymnName = "O My Father",
                    HymnNumber = 292
                    },
                    new Hymn {
                    HymnName = "Each Life That Touches Ours for Good",
                    HymnNumber = 293
                    },
                    new Hymn {
                    HymnName = "Love at Home",
                    HymnNumber = 294
                    },
                    new Hymn {
                    HymnName = "O Love That Glorifies the Son",
                    HymnNumber = 295
                    },
                    new Hymn {
                    HymnName = "Our Father, by Whose Name",
                    HymnNumber = 296
                    },
                    new Hymn {
                    HymnName = "From Homes of Saints Glad Songs Arise",
                    HymnNumber = 297
                    },
                    new Hymn {
                    HymnName = "Home Can Be a Heaven on Earth",
                    HymnNumber = 298
                    },
                    new Hymn {
                    HymnName = "Children of Our Heavenly Father",
                    HymnNumber = 299
                    },
                    new Hymn {
                    HymnName = "Families Can Be Together Forever",
                    HymnNumber = 300
                    },
                    new Hymn {
                    HymnName = "I Am a Child of God",
                    HymnNumber = 301
                    },
                    new Hymn {
                    HymnName = "I Know My Father Lives",
                    HymnNumber = 302
                    },
                    new Hymn {
                    HymnName = "Keep the Commandments",
                    HymnNumber = 303
                    },
                    new Hymn {
                    HymnName = "Teach Me to Walk in the Light",
                    HymnNumber = 304
                    },
                    new Hymn {
                    HymnName = "The Light Divine",
                    HymnNumber = 305
                    },
                    new Hymn {
                    HymnName = "God's Daily Care",
                    HymnNumber = 306
                    },
                    new Hymn {
                    HymnName = "In Our Lovely Deseret",
                    HymnNumber = 307
                    },
                    new Hymn {
                    HymnName = "Love One Another",
                    HymnNumber = 308
                    },
                    new Hymn {
                    HymnName = "As Sisters in Zion (Women)",
                    HymnNumber = 309
                    },
                    new Hymn {
                    HymnName = "A Key Was Turned in Latter Days (Women)",
                    HymnNumber = 310
                    },
                    new Hymn {
                    HymnName = "We Meet Again as Sisters (Women)",
                    HymnNumber = 311
                    },
                    new Hymn {
                    HymnName = "We Ever Pray for Thee",
                    HymnNumber = 312
                    },
                    new Hymn {
                    HymnName = "God Is Love(Women)",
                    HymnNumber = 313
                    },
                    new Hymn {
                    HymnName = "How Gentle God’s Commands",
                    HymnNumber = 314
                    },
                    new Hymn {
                    HymnName = "Jesus, the Very Thought of Thee (Women)",
                    HymnNumber = 315
                    },
                    new Hymn {
                    HymnName = "The Lord Is My Shepherd",
                    HymnNumber = 316
                    },
                    new Hymn {
                    HymnName = "Sweet Is the Work",
                    HymnNumber = 317
                    },
                    new Hymn {
                    HymnName = "Love at Home",
                    HymnNumber = 318
                    },
                    new Hymn {
                    HymnName = "Ye Elders of Israel",
                    HymnNumber = 319
                    },
                    new Hymn {
                    HymnName = "The Priesthood of Our Lord",
                    HymnNumber = 320
                    },
                    new Hymn {
                    HymnName = "Ye Who Are Called to Labor (Men)",
                    HymnNumber = 321
                    },
                    new Hymn {
                    HymnName = "Come, All Ye Sons of God",
                    HymnNumber = 322
                    },
                    new Hymn {
                    HymnName = "Rise Up, O Men of God",
                    HymnNumber = 323
                    },
                    new Hymn {
                    HymnName = "Rise Up, O Men of God (Men)",
                    HymnNumber = 324
                    },
                    new Hymn {
                    HymnName = "See the Mighty Priesthood Gathered (Men's Choir)",
                    HymnNumber=325
                    },
                    new Hymn {
                    HymnName = "Come, Come, Ye Saints",
                    HymnNumber = 326
                    },
                    new Hymn {
                    HymnName = "Go, Ye Messengers of Heaven (Men's Choir)",
                    HymnNumber=327
                    },
                    new Hymn {
                    HymnName = "An Angel from on High",
                    HymnNumber = 328
                    },
                    new Hymn {
                    HymnName = "Thy Servants Are Prepared (Men's Choir)",
                    HymnNumber=329
                    },
                    new Hymn {
                    HymnName = "See, the Mighty Angel Flying (Men's Choir)",
                    HymnNumber=330
                    },
                    new Hymn {
                    HymnName = "Oh Say, What Is Truth? (Men's Choir)",
                    HymnNumber=331
                    },
                    new Hymn {
                    HymnName = "Come, O Thou King of Kings (Men's Choir)",
                    HymnNumber=332
                    },
                    new Hymn {
                    HymnName = "High on the Mountain Top",
                    HymnNumber = 333
                    },
                    new Hymn {
                    HymnName = "I Need Thee Every Hour (Men's Choir)",
                    HymnNumber=334
                    },
                    new Hymn {
                    HymnName = "Brightly Beams Our Father’s Mercy",
                    HymnNumber = 335
                    },
                    new Hymn {
                    HymnName = "School Thy Feelings",
                    HymnNumber = 336
                    },
                    new Hymn {
                    HymnName = "O Home Beloved",
                    HymnNumber = 337
                    },
                    new Hymn {
                    HymnName = "America the Beautiful",
                    HymnNumber = 338
                    },
                    new Hymn {
                    HymnName = "My Country, 'Tis of Thee",
                    HymnNumber=339
                    },
                    new Hymn {
                    HymnName = "The StarSpangled Banner",
                    HymnNumber = 340
                    },
                    new Hymn {
                    HymnName = "God Save the King",
                    HymnNumber = 341
                    }
                );
                }

                if (context.Person.Any())
                {
                    return; // People in DB, no need to add more! :)
                }
                else
                {
                    context.Person.AddRange(
                    
                        new Person
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            PersonPrefix = Prefix.Bishop,

                        },
                        new Person
                        {
                            FirstName = "Mary",
                            LastName = "Smith",
                            PersonPrefix = Prefix.Sister,

                        },
                        new Person
                        {
                            FirstName = "Peter",
                            LastName = "Johnson",
                            PersonPrefix = Prefix.Brother,

                        },
                        new Person
                        {
                            FirstName = "Emily",
                            LastName = "Johnson",
                            PersonPrefix = Prefix.Sister,

                        },
                        new Person
                        {
                            FirstName = "Felix",
                            LastName = "Johnson",
                            PersonPrefix = Prefix.Brother,

                        },
                        new Person
                        {
                            FirstName = "Marissa",
                            LastName = "Anderson",
                            PersonPrefix = Prefix.Sister,

                        },
                        new Person
                        {
                            FirstName = "Jonas",
                            LastName = "Peterson",
                            PersonPrefix = Prefix.Brother,

                        },
                        new Person
                        {
                            FirstName = "Rose",
                            LastName = "Page",
                            PersonPrefix = Prefix.Sister,

                        },
                        new Person
                        {
                            FirstName = "Hyrum",
                            LastName = "Page",
                            PersonPrefix = Prefix.Elder,
                        }
                    );
                }
                context.SaveChanges();
            }
        }
    }
}